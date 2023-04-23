using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom_Bach
{
    // класс для промежуточных вычислений
    internal class Calculate
    {
        // функция для первого этапа вычислений
        public void FirstStepCalculate(List<int> c, List<int> gx, List<int> fc, List<int> xc, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                xc[i] = c[i];
            }

            for(int i = 0; i < rows; i++)
            {
                fc[i] = gx[i];
            }
        }

        public void SecondStepCalculate(List<int> fc,int rows, List<int> x1)
        {
            for(int i=0;i<rows;i++)
            {
                x1.Add(fc[i] + 0);
            }
        }


    }
}
