using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03_kalk_proc
{
    internal class user_input
    {
        private double dish_vol = 0;
        private double subst_percent = 0;
        private int dish_numb = 0;


        public user_input(double dish_vol, double subst_percent, int dish_numb)
        {
            this.dish_vol = dish_vol;
            this.subst_percent = subst_percent;
            this.dish_numb = dish_numb;
        }

        // Metoda do obliczenia łącznej objętości
        public double Subst_sum()
        {
            return dish_vol * dish_numb;
        }

        // Metoda do obliczenia objętości czystej substancji
        public double Clean_subst_vol()
        {
            return Subst_sum() * (subst_percent / 100);
        }
    }
}
