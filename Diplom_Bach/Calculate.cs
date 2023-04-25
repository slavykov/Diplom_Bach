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

        public void SecondStepCalculate(List<int> fc, List<int> x,List<int> cUp, List<int> cLeft, List<int> fccount,List<int> gx, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                x.Add(fc[i] + 0);
            }

            int indexOfgx = rows;

            
            int b = 0;
            for (int i = 1; i < cUp.Count; i++)
            {
                for (int j = 0; j < cLeft.Count; j++)
                {
                    if (cUp[i] <= cLeft[j])
                    {
                        x.Add(gx[indexOfgx] + fccount[b]);
                        b++;
                    }
                    else
                    {
                        x.Add(0);
                        b = 0;
                    }
                
                }
                indexOfgx++;
            }
        }


    }
}
