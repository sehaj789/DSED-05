namespace DSED_05.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Racer Class.
    /// </summary>
    internal class Racer
    {
        /// <summary>
        /// Gets or sets racer Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets racer Length.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets racer Picture Box.
        /// </summary>
        public PictureBox PB { get; set; }
    }
}
