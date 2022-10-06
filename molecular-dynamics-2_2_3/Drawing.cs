using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace molecular_dynamics_2_2_3
{
	public class Drawing
	{
		private PictureBox _pictureBox;
		private Graphics _graphics;
		private Bitmap _bitmap;
		private readonly double _alpha, _beta;

		public Drawing(PictureBox pB, double x1, double y1, double x2, double y2)
		{
			_pictureBox = pB;
			_bitmap = new Bitmap(_pictureBox.Width, _pictureBox.Height);
			_graphics = Graphics.FromImage(_bitmap);
			_graphics.SmoothingMode = SmoothingMode.AntiAlias;
			_graphics.TranslateTransform(0, _pictureBox.Height);
			
			// Вычисление коэффициентов преобразование.
			_alpha = _pictureBox.Width / (x2 - x1);
			_beta = -_pictureBox.Height / (y2 - y1);

			_pictureBox.Image = _bitmap;
		}

		/// <summary>
		/// Очищает область.
		/// </summary>
		public void Clear()
		{
			_graphics.Clear(Color.White);
			// _graphics.Flush();
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
			var pen = new Pen(Color.Black);
			_graphics.FillEllipse(brush, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height));
			_graphics.DrawEllipse(pen, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height));
		}

		/// <summary>
		/// Рисует атомы в области расчётной ячейки.
		/// </summary>
		/// <param name="positions">Список атомов.</param>
		/// <param name="r0">Радиус шарика.</param>
		public void DrawAtoms(List<Vector2D> positions, double r0, double l)
		{
			positions.ForEach(pos =>
			{
				var periodicPos = pos;
				var isPeriodic = false;
				DrawFillEllipse(Color.Blue, pos.X, pos.Y, r0, r0);
				if (pos.X <= r0)
				{
					periodicPos = new Vector2D(periodicPos.X + l, periodicPos.Y);
					isPeriodic = true;
				}
				if (l - pos.X <= r0)
				{
					periodicPos = new Vector2D(periodicPos.X - l, periodicPos.Y);
					isPeriodic = true;
				}
				if (pos.Y <= r0)
				{
					periodicPos = new Vector2D(periodicPos.X, periodicPos.Y + l);
					isPeriodic = true;
				}
				if (l - pos.Y <= r0)
				{
					periodicPos = new Vector2D(periodicPos.X, periodicPos.Y - l);
					isPeriodic = true;
				}
				if (isPeriodic) 			
					DrawFillEllipse(Color.Blue, periodicPos.X, periodicPos.Y, r0, r0);
			});
		}
	}
}
