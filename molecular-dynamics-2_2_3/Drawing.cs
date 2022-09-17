using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace molecular_dynamics_2_2_3
{
    public class Drawing
    {
        private readonly PictureBox pictureBox;
        public readonly Graphics graphics;
        private readonly Bitmap bitmap;

        private readonly double wnd_Xmin, wnd_Xmax, wnd_Ymin, wnd_Ymax;
        private readonly double alpha, beta;

        public Drawing(PictureBox pB, double x1, double y1, double x2, double y2)
        {
            pictureBox = pB;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TranslateTransform(0, pictureBox.Height);
            // Относительные размеры окна рисования.
            wnd_Xmin = x1; wnd_Xmax = x2;
            wnd_Ymin = y1; wnd_Ymax = y2;
            // Вычисление коэффициентов преобразование.
            alpha = pictureBox.Width / (wnd_Xmax - wnd_Xmin);
            beta = -pictureBox.Height / (wnd_Ymax - wnd_Ymin);

            pictureBox.Image = bitmap;
        }

        /// <summary>
        /// Очищает область.
        /// </summary>
        public void Clear()
        {
            graphics.Clear(Color.Black);
        }

        /// <summary>
        /// Преобразует мировые координаты в координаты окна (пиксели).
        /// </summary>
        /// <param name="x">X в мировых координатах.</param>
        /// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
        private float OutX(double x)
        {
            return (float)(x * alpha);
        }

        /// <summary>
        /// Преобразует мировые координаты в координаты окна (пиксели).
        /// </summary>
        /// <param name="y">Y мировых координатах.s</param>
        /// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
        private float OutY(double y)
        {
            return (float)(y * beta);
        }

        /// <summary>
        /// Рисует прямую линию между двумя заданными точками.
        /// </summary>
        /// <param name="color">Цвет линии.</param>
        /// <param name="x1">X-положение начальной точки в мировых координатах.</param>
        /// <param name="y1">Y-положение начальной точки в мировых координатах.</param>
        /// <param name="x2">X-положение конечной точки в мировых координатах.</param>
        /// <param name="y2">Y-положение конечной точки в мировых координатах.</param>
        private void DrawLine(Color color, double x1, double y1, double x2, double y2, float width = 1f)
        {
            Pen pen = new Pen(color)
            {
                Width = width,
                DashStyle = DashStyle.Solid
            };
            graphics.DrawLine(pen, OutX(x1), OutY(y1), OutX(x2), OutY(y2));
            graphics.Flush();
        }

        /// <summary>
        /// Рисует заполненный эллипс.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void DrawFillEllipse(Color color, double x, double y, double width, double height)
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height));
            graphics.Flush();
        }

        public void DrawAtoms(Color color, List<Atom> atoms, double L)
        {
            foreach ( Atom atom in atoms)
                DrawFillEllipse(color, atom.Position.X, atom.Position.Y, 0.01 * L, 0.01 * L);
        }
    }
}
