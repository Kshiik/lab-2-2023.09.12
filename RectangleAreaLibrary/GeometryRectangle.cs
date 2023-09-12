using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAreaLibrary
{
    public class GeometryRectangle
    {
        /// <summary>
        /// Просчитывает площадь прямоугольника
        /// </summary>
        /// <param name="width">
        /// ширина прямоуголька
        /// </param>
        /// <param name="height">
        /// высота прямоугольника
        /// </param>
        /// <returns>
        /// Метод возращвет площадь прямокгольника
        /// </returns>
        /// <exception cref="Exception"></exception>
        public double RectangleArea(string width, string height)
        {
            if (width == null || height == null || width.Length == 0 || height.Length == 0)
            {
                throw new Exception("Входные данные не валидны");
            }

            width = width.Replace('.', ',');
            height = height.Replace('.', ',');

            double widhtNumber;
            double heightNumber;

            if (!double.TryParse(width, out widhtNumber))
            {
                throw new Exception("Ширина не явлсяется числом");
            }

            if (!double.TryParse(height, out heightNumber))
            {
                throw new Exception("Высота не явлсяется числом");
            }

            if (widhtNumber <= 0 || heightNumber <= 0)
            {
                throw new Exception("Длины строн не могут быть меньше нуля");
            }

            return widhtNumber * heightNumber;
        }
    }
}
