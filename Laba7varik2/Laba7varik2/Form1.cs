using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laba7varik2;

public partial class Form1 : Form
{
    private Graphics graph;
    private Pen pen;
    private Pen axisPen;
    private Font FontString;
    private Brush Brush;
    private const double deltaX = 0.1;

    public Form1()
    {
        InitializeComponent();
        this.Resize += new EventHandler(Form1_Resize);
        this.Paint += new PaintEventHandler(Form1_Paint);
        pen = new Pen(Color.Blue, 1);
        axisPen = new Pen(Color.Black, 1);
        Font = new Font("Arial", 12);
        Brush = Brushes.Black;
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
        Invalidate();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        graph = e.Graphics;
        DrawGraph();
    }

    private void DrawGraph()
    {
        double xStart = 0.1;
        double xEnd = 1.2;

        int formWidth = this.ClientSize.Width;
        int formHeight = this.ClientSize.Height;

        float scaleX = formWidth / (float)(xEnd - xStart);
        float scaleY = formHeight / 1.0f;

        graph.DrawLine(axisPen, 0, formHeight / 2, formWidth, formHeight / 2);
        graph.DrawLine(axisPen, formWidth / 2, 0, formWidth / 2, formHeight);

        DrawTicks(formWidth, formHeight);

        double x = xStart;
        double y = Function(x);
        float prevX = (float)((x - xStart) * scaleX);
        float prevY = formHeight / 2 - (float)(y * scaleY);

        for (x = xStart + deltaX; x <= xEnd; x += deltaX)
        {
            y = Function(x);

            float currentX = (float)((x - xStart) * scaleX);
            float currentY = formHeight / 2 - (float)(y * scaleY);

            graph.DrawLine(pen, prevX, prevY, currentX, currentY);

            prevX = currentX;
            prevY = currentY;
        }
        DrawArrow(graph, formWidth, formHeight);

        graph.DrawString("x", new Font("Arial", 12), Brushes.Black, formWidth - 20, (float)(formHeight / 2.23));
        graph.DrawString("y", new Font("Arial", 12), Brushes.Black, (float)(formWidth / 2.08), 5);
    }

    private double Function(double x)
    {
        return (Math.Tan(0.5 * x)) / (Math.Pow(x, 3) + 7.5);
    }
    private void DrawTicks(int formWidth, int formHeight)
    {
        int tickSize = 5;
        int stepX = 50; 
        int stepY = 50;

        for (int i = formWidth / 2, tickValue = 0; i < formWidth; i += stepX, tickValue++)
        {
            graph.DrawLine(axisPen, i, formHeight / 2 - tickSize, i, formHeight / 2 + tickSize);
            graph.DrawString(tickValue.ToString(), new Font("Arial", 10), Brushes.Black, i - 10, formHeight / 2 + 10); 
        }
        for (int i = formWidth / 2 - stepX, tickValue = -1; i > 0; i -= stepX, tickValue--)
        {
            graph.DrawLine(axisPen, i, formHeight / 2 - tickSize, i, formHeight / 2 + tickSize);
            graph.DrawString(tickValue.ToString(), new Font("Arial", 10), Brushes.Black, i - 10, formHeight / 2 + 10); 
        }

        for (int i = formHeight / 2 - stepY, tickValue = 1; i > 0; i -= stepY, tickValue++)
        {
            graph.DrawLine(axisPen, formWidth / 2 - tickSize, i, formWidth / 2 + tickSize, i); 
            graph.DrawString(tickValue.ToString(), new Font("Arial", 10), Brushes.Black, formWidth / 2 + 10, i - 10); 
        }
        for (int i = formHeight / 2 + stepY, tickValue = -1; i < formHeight; i += stepY, tickValue++)
        {
            graph.DrawLine(axisPen, formWidth / 2 - tickSize, i, formWidth / 2 + tickSize, i); 
            graph.DrawString(tickValue.ToString(), new Font("Arial", 10), Brushes.Black, formWidth / 2 + 10, i - 10); 
        }
    }

    private void DrawArrow(Graphics graph, int formWidth, int formHeight)
    {
        Point[] arrowX = {
        new Point(formWidth - 10, formHeight / 2 - 5),
        new Point(formWidth, formHeight / 2),
        new Point(formWidth - 10, formHeight / 2 + 5)
    };
        graph.FillPolygon(Brushes.Black, arrowX);

        Point[] arrowY = {
        new Point(formWidth / 2 - 5, 10),
        new Point(formWidth / 2, 0),
        new Point(formWidth / 2 + 5, 10)
    };
        graph.FillPolygon(Brushes.Black, arrowY);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}
