using System;

namespace molecular_dynamics_2_2_3
{
	public struct Vector2D
	{
		public double X, Y;

		/// <summary>
		/// Создание структуры Vector2D.
		/// </summary>
		/// <param name="x">Координата х.</param>
		/// <param name="y">Координата y.</param>
		public Vector2D(double x, double y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// Нулевой вектор.
		/// </summary>
		public static Vector2D Zero => new Vector2D(0, 0);

		/// <summary>
		/// Единичный вектор.
		/// </summary>
		public static Vector2D One => new Vector2D(1, 1);

		/// <summary>
		/// Длина вектора до точки.
		/// </summary>
		/// <param name="vec">Конечная точка.</param>
		public double Magnitude(Vector2D vec) => Math.Sqrt((vec.X - X) * (vec.X - X) + (vec.Y - Y) * (vec.Y - Y));

		/// <summary>
		/// Длина вектора.
		/// </summary>
		public double Magnitude() => Math.Sqrt(SquaredMagnitude());

		/// <summary>
		/// Расстояние между точками.
		/// </summary>
		/// <param name="vec1">Начальная точка.</param>
		/// <param name="vec2">Конечная точка.</param>
		/// <returns></returns>
		public static double Magnitude(Vector2D vec1, Vector2D vec2) => Math.Sqrt((vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y));

		public double SquaredMagnitude() => X * X + Y * Y;

		/// <summary>
		/// Возвращает значение наибольшей координаты.
		/// </summary>
		/// <returns></returns>
		public double GetMax() => Math.Max(X, Y);

		/// <summary>
		/// Возвращает значение наименьшей координаты.
		/// </summary>
		/// <returns></returns>
		public double GetMin() => Math.Min(X, Y);

		/// <summary>
		/// Сложение координат.
		/// </summary>
		/// <param name="vec1">Первая координата.</param>
		/// <param name="vec2">Вторая координата.</param>
		/// <returns></returns>
		public static Vector2D operator +(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X + vec2.X, vec1.Y + vec2.Y);

		/// <summary>
		/// Сложение координат.
		/// </summary>
		/// <param name="vec1">Первая координата.</param>
		/// <param name="value">Число.</param>
		/// <returns></returns>
		public static Vector2D operator +(Vector2D vec1, double value) => new Vector2D(vec1.X + value, vec1.Y + value);

		/// <summary>
		/// Вычитание из одной координаты другой координаты.
		/// </summary>
		/// <param name="vec1">Первая координата.</param>
		/// <param name="vec2">Вторая координата.</param>
		/// <returns></returns>
		public static Vector2D operator -(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X - vec2.X, vec1.Y - vec2.Y);

		/// <summary>
		/// Вычитание из одной координаты другой координаты.
		/// </summary>
		/// <param name="vec1">Первая координата.</param>
		/// <param name="value">Число.</param>
		/// <returns></returns>
		public static Vector2D operator -(Vector2D vec1, double value) => new Vector2D(vec1.X - value, vec1.Y - value);

		/// <summary>
		/// Перемножение координат.
		/// </summary>
		/// <param name="vec1">Первая координата.</param>
		/// <param name="vec2">Вторая координата.</param>
		/// <returns></returns>
		public static Vector2D operator *(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X * vec2.X, vec1.Y * vec2.Y);

		/// <summary>
		/// Умножение числа с плавающей запятой на точку справа.
		/// </summary>
		/// <param name="vec">Координата точки.</param>
		/// <param name="num">Домножаемое число.</param>
		/// <returns></returns>
		public static Vector2D operator *(Vector2D vec, double num) => new Vector2D(vec.X * num, vec.Y * num);

		/// <summary>
		/// Умножение целого числа на точку справа.
		/// </summary>
		/// <param name="vec">Координата точки.</param>
		/// <param name="num">Домножаемое число.</param>
		/// <returns></returns>
		public static Vector2D operator *(Vector2D vec, int num) => new Vector2D(vec.X * num, vec.Y * num);

		/// <summary>
		/// Умножение числа с плавающей запятой на точку слева.
		/// </summary>
		/// <param name="vec">Координата точки.</param>
		/// <param name="num">Домножаемое число.</param>
		/// <returns></returns>
		public static Vector2D operator *(double num, Vector2D vec) => new Vector2D(vec.X * num, vec.Y * num);

		/// <summary>
		/// Умножение целого числа на точку слева.
		/// </summary>
		/// <param name="vec">Координата точки.</param>
		/// <param name="num">Домножаемое число.</param>
		/// <returns></returns>
		public static Vector2D operator *(int num, Vector2D vec) => new Vector2D(vec.X * num, vec.Y * num);

		/// <summary>
		/// Деление одной координаты на другую.
		/// </summary>
		/// <param name="vec1">Первая координата.</param>
		/// <param name="vec2">Вторая координата.</param>
		/// <returns></returns>
		public static Vector2D operator /(Vector2D vec1, Vector2D vec2) => new Vector2D(vec1.X / vec2.X, vec1.Y / vec2.Y);

		/// <summary>
		/// Деление точки на число с плавающей запятой.
		/// </summary>
		/// <param name="vec">Координата точки.</param>
		/// <param name="num">Число-делитель.</param>
		/// <returns></returns>
		public static Vector2D operator /(Vector2D vec, double num) => new Vector2D(vec.X / num, vec.Y / num);

		/// <summary>
		/// Деление точки на целое число.
		/// </summary>
		/// <param name="vec">Координата точки.</param>
		/// <param name="num">Число-делитель.</param>
		public static Vector2D operator /(Vector2D vec, int num) => new Vector2D(vec.X / num, vec.Y / num);
	}
}