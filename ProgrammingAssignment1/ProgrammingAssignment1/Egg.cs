using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// An egg
    /// </summary>
    public class Egg
    {
        #region Fields

        private int amountLeft;
        private EggColor color;
        private HowCooked howCooked = HowCooked.NotCooked;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size">egg size</param>
        /// <param name="color">egg color</param>
        public Egg(int size, EggColor color)
        {
            amountLeft = size;
            this.color = color;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets how much egg is left to eat
        /// </summary>
        public int AmountLeft
        {
            get
            {
                // replace the line of code below with correct code
                return amountLeft;
            }
        }

        /// <summary>
        /// Gets the color of the egg
        /// </summary>
        public EggColor Color
        {
            get
            {
                // replace the line of code below with correct code
                return color;
            }
        }

        /// <summary>
        /// Gets how the egg is cooked
        /// </summary>
        public HowCooked CookedStatus
        {
            get
            {
                // replace the line of code below with correct code
                return howCooked;
            }
        }

        /// <summary>
        /// Gets whether or not the egg is cooked
        /// </summary>
        public bool IsCooked
        {
            get
            {
                // replace the line of code below with correct code
                if (howCooked != HowCooked.NotCooked)
                {
                    return true;
                }

                return false;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Cooks the egg
        /// </summary>
        /// <param name="howToCook">how the egg should be cooked</param>
        public void Cook(HowCooked howToCook)
        {
            if (!IsCooked)
            {
                howCooked = howToCook;
            } else
            {
                // Console.WriteLine("This egg is already cooked. This egg cannot be cooked again");
            }
        }

        /// <summary>
        /// Takes a bite of the given size from the egg. Only takes
        /// a bite if the egg is cooked
        /// </summary>
        /// <param name="size">size of the bite to take</param>
        public void TakeBite(int size)
        {
            if (size >= amountLeft)
            {
                amountLeft = 0;
            }
            else if (amountLeft != 0 && this.IsCooked)
            {
                amountLeft -= size;
            }
        }

            /// <summary>
            /// Dyes the egg the given color. Only white eggs can be dyed,
            /// and eggs can only be dyed blue
            /// </summary>
            /// <param name="color">color to dye the egg</param>
            public void Dye(EggColor color)
        {
            if (this.color == EggColor.White && color == EggColor.Blue)
            {
                this.color = color;
            } else if (this.color == EggColor.Blue)
            {
                // Console.WriteLine("Egg has already been dyed");
            } else
            {
                // Console.WriteLine("Egg cannot be dyed the given colour");
            }
        }

        #endregion
    }
}
