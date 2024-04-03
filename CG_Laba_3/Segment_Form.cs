using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Laba_3
{
    public partial class Segment_Form : Form
    {
        private const int GridWidth = 630;
        private const int GridHeight = 630;
        private const int CellSize = 30;
        private int x1Start, y1Start, x2Start, y2Start;
        bool reflectionXY = false;
        private List<Action> drawActions = new List<Action>();
        private Graphics g;
        private Bitmap bitmap;


        private void ExecuteNextAction()
        {
            if (drawActions.Count > 0)
            {
                drawActions[0]();
                drawActions.RemoveAt(0);
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            nextStep_Button.Visible = true;
            start_button.Visible = false;
            x1Start = (int)x1_numericUpDown.Value;
            y1Start = (int)y1_numericUpDown.Value;
            x2Start = (int)x2_numericUpDown.Value;
            y2Start = (int)y2_numericUpDown.Value;
            Normalization();
        }
        private void nextStep_Button_Click(object sender, EventArgs e)
        {
            ExecuteNextAction();
        }

        private void Exit()
        {
            nextStep_Button.Visible = false;
            exit_Button.Visible=true;
        }

        private void Normalization()
        {
            drawActions.Add(() => DrawBresenhamSegment(x1Start, y1Start, x2Start, y2Start));
            int dx = Math.Abs(x2Start - x1Start);
            int dy = Math.Abs(y2Start - y1Start);
            int x2New = dx;
            int y2New = dy;
            drawActions.Add(() => DrawBresenhamSegment(0, 0, dx, dy));
            if (x2New < y2New)
            {
                (x2New, y2New) = (y2New, x2New);
                reflectionXY = true;
                drawActions.Add(() => DrawBresenhamSegment(0, 0, x2New, y2New));
            }
            drawActions.Add(() => BresenhamSegment(0, 0, x2New, y2New));
            ExecuteNextAction();
        }

        private void ReverseNormalization(int x1, int y1, int x2, int y2, List<Point> points)
        {
            int pointsCount = points.Count();
            List<Point> tmp = new List<Point>();
            if (reflectionXY)
            {
                foreach (var point in points)
                {
                    tmp.Add(new Point(point.Y, point.X));
                }
                points = tmp;
            }
            DrawBresenhamSegment(points[0].X, points[0].Y, points[pointsCount - 1].X, points[pointsCount - 1].Y, points);
            for (int i = 0; i < pointsCount; i++)
            {
                int tmpX = Math.Min(x1, x2) + points[i].X;
                int tmpY = Math.Min(y1, y2) + points[i].Y;
                points[i] = new Point(tmpX, tmpY);
            }
            drawActions.Add(() => DrawBresenhamSegment(points[0].X, points[0].Y, points[pointsCount - 1].X, points[pointsCount - 1].Y, points));
            drawActions.Add(() => Exit());
        }


        private void BresenhamSegment(int x1, int y1, int x2, int y2)
        {
            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int error = 2 * dy - dx;
            int x = 0;
            int y = 0;
            List<Point> points = new List<Point>();

            for (int i = 0; i <= x2; i++)
            {
                points.Add(new Point(x, y));
                if (error > 0)
                {
                    y++;
                    error -= 2 * dx;
                }
                x++;
                error += 2 * dy;
                List<Point> currentPoints = new List<Point>(points);

                drawActions.Add(() =>
                {
                    DrawBresenhamSegment(x1, y1, x2, y2, currentPoints);
                });
            }
            drawActions.Add(() => ReverseNormalization(x1Start, y1Start, x2Start, y2Start, points));
        }


        private void DrawBresenhamSegment(int x1, int y1, int x2, int y2, List<Point>? points = null)
        {
            ClearCanvas();
            DrawGrid();
            List<Point> standartPointsTmp = new List<Point>();
            standartPointsTmp.Add(new Point(x1, y1));
            standartPointsTmp.Add(new Point(x2, y2));
            List<Point> convertedStantardPoints = PointConvertionToCoordinates(standartPointsTmp);
            g.DrawLines(Pens.Red, convertedStantardPoints.ToArray());
            DrawPoints(convertedStantardPoints, Brushes.Red);
            if (points != null)
            {
                List<Point> bresenhamPointsConverted = PointConvertionToCoordinates(points);
                DrawPoints(bresenhamPointsConverted, Brushes.Blue);
            }

        }

        void DrawPoints(List<Point> points, Brush brush)
        {
            int radius = 12;
            foreach (var point in points)
            {
                g.FillEllipse(brush, point.X - radius / 2, point.Y - radius / 2, radius, radius);
            }
        }
        public Segment_Form()
        {
            InitializeComponent();
            bitmap = new Bitmap(GridWidth, GridHeight);
            g = Graphics.FromImage(bitmap);
            DrawGrid();
            x1Start = (int)x1_numericUpDown.Value;
            y1Start = (int)y1_numericUpDown.Value;
            x2Start = (int)x2_numericUpDown.Value;
            y2Start = (int)y2_numericUpDown.Value;
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
            segment_pictureBox.Image = bitmap;
        }

        private void ClearCanvas()
        {
            segment_pictureBox.Refresh();
            g.Clear(Color.White);
        }
    }
}
