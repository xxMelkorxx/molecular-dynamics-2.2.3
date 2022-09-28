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
		private readonly PictureBox _pictureBox;
		private readonly Graphics _graphics;
		private readonly Bitmap _bitmap;

		private readonly double _wnd_Xmin, _wnd_Xmax, _wnd_Ymin, _wnd_Ymax;
		private readonly double _alpha, _beta;

		public Drawing(PictureBox pB, double x1, double y1, double x2, double y2)
		{
			_pictureBox = pB;
			_bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
			_graphics = Graphics.FromImage(_bitmap);

			_graphics.SmoothingMode = SmoothingMode.AntiAlias;
			_graphics.TranslateTransform(0, _pictureBox.Height);
			// Относительные размеры окна рисования.
			_wnd_Xmin = x1; _wnd_Xmax = x2;
			_wnd_Ymin = y1; _wnd_Ymax = y2;
			// Вычисление коэффициентов преобразование.
			_alpha = _pictureBox.Width / (_wnd_Xmax - _wnd_Xmin);
			_beta = -_pictureBox.Height / (_wnd_Ymax - _wnd_Ymin);

			_pictureBox.Image = _bitmap;
		}

		/// <summary>
		/// Очищает область.
		/// </summary>
		public void Clear()
		{
			_graphics.Clear(Color.Black);
		}

		/// <summary>
		/// Преобразует мировые координаты в координаты окна (пиксели).
		/// </summary>
		/// <param name="x">X в мировых координатах.</param>
		/// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
		private float OutX(double x)
		{
			return (float)(x * _alpha);
		}

		/// <summary>
		/// Преобразует мировые координаты в координаты окна (пиксели).
		/// </summary>
		/// <param name="y">Y мировых координатах.s</param>
		/// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
		private float OutY(double y)
		{
			return (float)(y * _beta);
		}

		/// <summary>
		/// Рисует прямую линию между двумя заданными точками.
		/// </summary>
		/// <param name="color">Цвет линии.</param>
		/// <param name="x1">X-положение начальной точки в мировых координатах.</param>
		/// <param name="y1">Y-положение начальной точки в мировых координатах.</param>
		/// <param name="x2">X-положение конечной точки в мировых координатах.</param>
		/// <param name="y2">Y-положение конечной точки в мировых координатах.</param>
		private void DrawLine(Color color, double x1, double y1, double x2, double y2, float width)
		{
			var pen = new Pen(color)
			{
				Width = width,
				DashStyle = DashStyle.Solid
			};
			_graphics.DrawLine(pen, OutX(x1), OutY(y1), OutX(x2), OutY(y2));
			_graphics.Flush();
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
			var brush = new SolidBrush(color);
			
			
			_graphics.FillEllipse(brush, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height));
			_graphics.Flush();
		}

		/// <summary>
		/// Рисует атомы в области расчётной ячейки.
		/// </summary>
		/// <param name="color">Цвет атомов.</param>
		/// <param name="atoms">Список атомов.</param>
		/// <param name="r0">Радиус шарика.</param>
		public void DrawAtoms(Color color, List<Atom> atoms, double r0)
		{
			atoms.ForEach(atom => DrawFillEllipse(color, atom.Position.X, atom.Position.Y, r0, r0));
		}
	}
}
