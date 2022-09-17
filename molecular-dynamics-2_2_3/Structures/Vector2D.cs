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
            X = x; Y = y;
        }
        /// <summary>
        /// Нулевой вектор.
        /// </summary>
        public static Vector2D Zero
        {
            get { return new Vector2D(0, 0); }
        }
        /// <summary>
        /// Единичный вектор.
        /// </summary>
        public static Vector2D One
        {
            get { return new Vector2D(1, 1); }
        }
        /// <summary>
        /// Длина вектора до точки.
        /// </summary>
        /// <param name="vector">Конечная точка.</param>
        public double Magnitude(Vector2D vector)
        {
            return Math.Sqrt(Math.Pow(vector.X - X, 2) + Math.Pow(vector.Y - Y, 2));
        }
        /// <summary>
        /// Длина вектора.
        /// </summary>
        public double Magnitude()
        {
            return Math.Sqrt(SquaredMagnitude());
        }
        /// <summary>
        /// Длина вектора.
        /// </summary>
        /// <param name="vector1">Начальная точка.</param>
        /// <param name="vector2">Конечная точка.</param>
        /// <returns></returns>
        public static double Magnitude(Vector2D vector1, Vector2D vector2)
        {
            return Math.Sqrt(Math.Pow(vector2.X - vector1.X, 2) + Math.Pow(vector2.Y - vector1.Y, 2));
        }
        public double SquaredMagnitude()
		{
            return X * X + Y * Y;
        }
        /// <summary>
        /// Возвращает значение наибольшей координаты.
        /// </summary>
        /// <returns></returns>
        public double GetMax()
        {
            return (X >= Y) ? X : Y;
        }
        /// <summary>
        /// Возвращает значение наименьшей координаты.
        /// </summary>
        /// <returns></returns>
        public double GetMin()
        {
            return (X <= Y) ? X : Y;
        }
        /// <summary>
        /// Сложение координат.
        /// </summary>
        /// <param name="vec1">Первая координата.</param>
        /// <param name="vec2">Вторая координата.</param>
        /// <returns></returns>
        public static Vector2D operator +(Vector2D vec1, Vector2D vec2)
        {
            return new Vector2D(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }
        /// <summary>
        /// Сложение координат.
        /// </summary>
        /// <param name="vec1">Первая координата.</param>
        /// <param name="value">Число.</param>
        /// <returns></returns>
        public static Vector2D operator +(Vector2D vec1, double value)
        {
            return new Vector2D(vec1.X + value, vec1.Y + value);
        }
        /// <summary>
        /// Вычитание из одной координаты другой координаты.
        /// </summary>
        /// <param name="vec1">Первая координата.</param>
        /// <param name="vec2">Вторая координата.</param>
        /// <returns></returns>
        public static Vector2D operator -(Vector2D vec1, Vector2D vec2)
        {
            return new Vector2D(vec1.X - vec2.X, vec1.Y - vec2.Y);
        }
        /// <summary>
        /// Вычитание из одной координаты другой координаты.
        /// </summary>
        /// <param name="vec1">Первая координата.</param>
        /// <param name="value">Число.</param>
        /// <returns></returns>
        public static Vector2D operator -(Vector2D vec1, double value)
        {
            return new Vector2D(vec1.X - value, vec1.Y - value);
        }
        /// <summary>
        /// Перемножение координат.
        /// </summary>
        /// <param name="vec1">Первая координата.</param>
        /// <param name="vec2">Вторая координата.</param>
        /// <returns></returns>
        public static Vector2D operator *(Vector2D vec1, Vector2D vec2)
        {
            return new Vector2D(vec1.X * vec2.X, vec1.Y * vec2.Y);
        }
        /// <summary>
        /// Деление одной координаты на другую.
        /// </summary>
        /// <param name="vec1">Первая координата.</param>
        /// <param name="vec2">Вторая координата.</param>
        /// <returns></returns>
        public static Vector2D operator /(Vector2D vec1, Vector2D vec2)
        {
            return new Vector2D(vec1.X / vec2.X, vec1.Y / vec2.Y);
        }
        /// <summary>
        /// Умножение числа с плавающей запятой на точку справа.
        /// </summary>
        /// <param name="vec">Координата точки.</param>
        /// <param name="num">Домножаемое число.</param>
        /// <returns></returns>
        public static Vector2D operator *(Vector2D vec, double num)
        {
            return new Vector2D(vec.X * num, vec.Y * num);
        }
        /// <summary>
        /// Умножение целого числа на точку справа.
        /// </summary>
        /// <param name="vec">Координата точки.</param>
        /// <param name="num">Домножаемое число.</param>
        /// <returns></returns>
        public static Vector2D operator *(Vector2D vec, int num)
        {
            return new Vector2D(vec.X * num, vec.Y * num);
        }
        /// <summary>
        /// Умножение числа с плавающей запятой на точку слева.
        /// </summary>
        /// <param name="vec">Координата точки.</param>
        /// <param name="num">Домножаемое число.</param>
        /// <returns></returns>
        public static Vector2D operator *(double num, Vector2D vec)
        {
            return new Vector2D(vec.X * num, vec.Y * num);
        }
        /// <summary>
        /// Умножение целого числа на точку слева.
        /// </summary>
        /// <param name="vec">Координата точки.</param>
        /// <param name="num">Домножаемое число.</param>
        /// <returns></returns>
        public static Vector2D operator *(int num, Vector2D vec)
        {
            return new Vector2D(vec.X * num, vec.Y * num);
        }
        /// <summary>
        /// Деление точки на число с плавающей запятой.
        /// </summary>
        /// <param name="vec">Координата точки.</param>
        /// <param name="num">Число-делитель.</param>
        /// <returns></returns>
        public static Vector2D operator /(Vector2D vec, double num)
        {
            return new Vector2D(vec.X / num, vec.Y / num);
        }
        /// <summary>
        /// Деление точки на целое число.
        /// </summary>
        /// <param name="vec">Координата точки.</param>
        /// <param name="num">Число-делитель.</param>
        public static Vector2D operator /(Vector2D vec, int num)
        {
            return new Vector2D(vec.X / num, vec.Y / num);
        }
    }
}