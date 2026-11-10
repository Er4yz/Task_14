using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Vector3D
    {
        #region Открытые поля и автосвойства
        public double X;
        public double Y;
        public double Z;
        #endregion

        #region Конструктор
        /// <summary>
        /// инициализурует все 3 оси
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="y">y</param>
        /// <param name="z">z</param>
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion

        #region Свойство
        public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);
        #endregion

        #region Методы экземпляра
        /// <summary>
        ///  прибавляет координаты другого вектора к текущему объекту.
        /// </summary>
        /// <param name="other">другой</param>
        public void Add(Vector3D other)
        {

        }
        #endregion
    }
}
