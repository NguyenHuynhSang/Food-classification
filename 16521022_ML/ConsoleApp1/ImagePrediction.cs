using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageClassification
{
    public class ImagePrediction
    {
        public float[] Score { get; set; }

        public uint PredictedLabel { get; set; }
    }
}
