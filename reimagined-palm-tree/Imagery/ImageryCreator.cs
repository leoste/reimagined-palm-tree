using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reimagined_palm_tree.Imagery
{
    public class ImageryCreator
    {
        //akssesseerib databaasi
        //on olemas eraldi pildid ja nende muudatuste loetelu, erinevad pildi staatused
        //saab mingi id põhjal kätte

        public ImageryCreator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new canvas that is the size of the given image and has the given image drawn on it.
        /// </summary>
        /// <param name="image">
        /// The image to make a canvas from.
        /// </param>
        public Canvas CreateCanvas(Image image)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates and returns a new canvas that is the given size.
        /// </summary>
        /// <param name="canvasSize">
        /// The size to make the canvas.
        /// </param>
        public Canvas CreateCanvas(Size canvasSize)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds and returns a canvas that has the given ID.
        /// </summary>
        /// <param name="canvasId">
        /// The ID of the canvas to be found.
        /// </param>
        public Canvas GetCanvas(Id canvasId)
        {
            throw new NotImplementedException();
        }
    }
}
