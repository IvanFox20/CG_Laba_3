using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Laba_3
{
    public partial class Circle_Form : Form
    {

        private const int GridWidth = 630;
        private const int GridHeight = 630;
        private const int CellSize = 30;
        private int xStart, yStart;
        private int rStart;
        private List<Action> drawActions = new List<Action>();
        private Graphics g;
        private Bitmap bitmap;

        public Circle_Form()
        {
            InitializeComponent();
            bitmap = new Bitmap(GridWidth, GridHeight);
            g = Graphics.FromImage(bitmap);
            DrawGrid();
            xStart = (int)x_numericUpDown.Value;
            yStart = (int)y_numericUpDown.Value;
            rStart = (int)r_numericUpDown.Value;
        }

        private void ExecuteNextAction()
        {
            if (drawActions.Count > 0)
            {
                drawActions[0]();
                drawActions.RemoveAt(0);
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            nextStep_Button.Visible = true;
            start_button.Visible = false;
            xStart = (int)x_numericUpDown.Value;
            yStart = (int)y_numericUpDown.Value;
            rStart = (int)r_numericUpDown.Value;
            Normalization(xStart, yStart, rStart);
        }

        private void nextStep_Button_Click(object sender, EventArgs e)
        {
            ExecuteNextAction();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit()
        {
            nextStep_Button.Visible = false;
            exit_Button.Visible = true;
        }

        private void Normalization(int x, int y,int r)
        {
            DrawBresenhamCircle((int)x,y,r);
            int xNew = 0;
            int yNew = 0;
            drawActions.Add(() => DrawBresenhamCircle((int)xNew, yNew, r));
            drawActions.Add(() => BresenhamCircle(r));
        }

        private void BresenhamCircle(int r)
        {
            int x = 0;
            int y = r;
            int delta = (x + 1) * (x + 1) + (y - 1) * (y - 1) - r * r;
            int distance = 0;
            List<Point> points = new List<Point>();
            while(x <= y)
            {
                points.Add(new Point(x,y));
                if (delta == 0)
                {
                    x++;
                    y--;
                }
                else if (delta < 0) // Расстояние от окружности до диагонального пикселя больше
                {
                    distance = Math.Abs((x + 1) * (x + 1) + y * y - r * r) - Math.Abs((x + 1) * (x + 1) + (y - 1) * (y - 1) - r * r);
                    if (distance >= 0)
                    {
                        x++;
                        y--;
                    }
                    else
                    {
                        x++;
                    }
                }
                else
                {
                    distance = Math.Abs((x + 1) * (x + 1) + (y - 1) * (y - 1) - r * r) - Math.Abs(x * x + (y - 1) * (y - 1) - r * r);
                    if (distance >= 0)
                    {
                        x++;
                        y--;
                    }
                    else
                    {
                        y--;
                    }
                }
            }
            DrawBresenhamCircle(0, 0, r, points);
            drawActions.Add(() => ReverseNormalization(points));
        }

        private void ReverseNormalization(List<Point> points)
        {
            int pointsCount = points.Count();
            List<Point> reflectionYX = ReflectionYX(points);
            List<Point> reflectionY = ReflectionY(reflectionYX);
            List<Point> reflectionX = ReflectionX(reflectionY);
            DrawBresenhamCircle(0, 0, rStart, reflectionYX);
            drawActions.Add(() => DrawBresenhamCircle(0, 0, rStart, reflectionY));
            drawActions.Add(() => DrawBresenhamCircle(0, 0, rStart, reflectionX));
            List<Point> resultPoints = new List<Point>(reflectionX);
            for (int i = 0; i < resultPoints.Count; i++)
            {
                int tmpX = xStart + resultPoints[i].X;
                int tmpY = yStart + resultPoints[i].Y;
                resultPoints[i] = new Point(tmpX, tmpY);
            }
            drawActions.Add(() => DrawBresenhamCircle(xStart, yStart, rStart, resultPoints));
            drawActions.Add(() => Exit());
        }

        private List<Point> ReflectionYX(List<Point> points)
        {
            List<Point> result = new List<Point>(points);
            for (int i = 0; i < points.Count; i++)
            {
                int tmpX = points[i].Y;
                int tmpY = points[i].X;
                result.Add(new Point(tmpX, tmpY));
            }
            return result;
        }

        private List<Point> ReflectionX(List<Point> points)
        {
            List<Point> result = new List<Point>(points);
            for (int i = 0; i < points.Count; i++)
            {
                int tmpX = -points[i].X;
                int tmpY = points[i].Y;
                result.Add(new Point(tmpX, tmpY));
            }
            return result;
        }
        private List<Point> ReflectionY(List<Point> points)
        {
            List<Point> result = new List<Point>(points);
            for (int i = 0; i < points.Count; i++)
            {
                int tmpX = points[i].X;
                int tmpY = -points[i].Y;
                result.Add(new Point(tmpX, tmpY));
            }
            return result;
        }

        private void DrawBresenhamCircle(int x, int y,int r, List<Point>? points = null)
        {
            ClearCanvas();
            DrawGrid();
            List<Point> standartPointsTmp = new List<Point>();
            standartPointsTmp.Add(new Point(x, y));
            List<Point> convertedStantardPoints = PointConvertionToCoordinates(standartPointsTmp);
            DrawCircle(convertedStantardPoints[0].X, convertedStantardPoints[0].Y, r); // стандартная отрисовка
            if (points != null)
            {
                List<Point> convertedPoints = PointConvertionToCoordinates(points);
                DrawPoints(convertedPoints, Brushes.Blue);
            }
        }

        private void DrawGrid()
        {
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                for (int xPos = 0; xPos <= GridWidth; xPos += CellSize)
                {
                    g.DrawLine(Pens.Black, xPos, 0, xPos, GridHeight);
                    int value = (xPos / CellSize) - 10;
                    string text = value.ToString();
                    SizeF textSize = g.MeasureString(text, this.Font);
                    float textX = xPos + (CellSize - textSize.Width) / 2;
                    float textY = GridHeight - 15;
                    g.DrawString(text, this.Font, Brushes.Black, textX, textY);
                }

                for (int yPos = 0; yPos <= GridHeight; yPos += CellSize)
                {
                    g.DrawLine(Pens.Black, 0, yPos, GridWidth, yPos);
                    int value = 10 - (yPos / CellSize);
                    g.DrawString(value.ToString(), this.Font, Brushes.Black, 0, yPos + 2);
                }
            }
            circle_pictureBox.Image = bitmap;
        }

        void DrawPoints(List<Point> points, Brush brush)
        {
            int radius = 12;
            foreach (var point in points)
            {
                g.FillEllipse(brush, point.X - radius / 2, point.Y - radius / 2, radius, radius);
            }
        }

        void DrawCircle(int x, int y, int r)
        {
            int normalizedRadis = r * 30;
            g.DrawEllipse(Pens.Red, x - normalizedRadis, y - normalizedRadis, normalizedRadis * 2, normalizedRadis * 2);
        }

        List<Point> PointConvertionToCoordinates(List<Point> points)
        {
            List<Point> newPoints = new List<Point>();
            foreach (Point point in points)
            {
                int newX = GridWidth / 2 + point.X * CellSize - CellSize / 2;
                int newY = GridHeight / 2 - point.Y * CellSize - CellSize / 2;
                newPoints.Add(new Point(newX, newY));
            }
            return newPoints;
        }

        private void ClearCanvas()
        {
            circle_pictureBox.Refresh();
            g.Clear(Color.White);
        }
    }
}
