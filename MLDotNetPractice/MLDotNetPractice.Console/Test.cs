using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace MLDotNetPractice.Console
{
   public class IrisData
   {
      [Column("0")]
      public float SepalLength;

      [Column("1")]
      public float SepalWidth;

      [Column("2")]
      public float PedalLength;

      [Column("3")]
      public float PedalWidth;
   }
   public class ClusterPrediction
   {
      [ColumnName("PredictedLabel")]
      public uint PredictedClusterId;

      [ColumnName("Score")]
      public float[] Distances;
   }

   public class Test
   {

   }
}
