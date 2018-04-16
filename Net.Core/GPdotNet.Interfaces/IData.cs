﻿//////////////////////////////////////////////////////////////////////////////////////////
// GPdotNET - Genetic Programming Tool                                                  //
// Copyright 2006-2017 Bahrudin Hrnjica                                                 //
//                                                                                      //
// This code is free software under the MIT License                                     //
// See license section of  http://github.com/bhrnjica/gpdotnet/blob/master/license.md  //
//                                                                                      //
// Bahrudin Hrnjica                                                                     //
// bhrnjica@hotmail.com                                                                 //
// Bihac,Bosnia and Herzegovina                                                         //
// http://bhrnjica.wordpress.com                                                        //
//////////////////////////////////////////////////////////////////////////////////////////
namespace GPdotNet.Interfaces
{
    public interface IData
    {
        int RowCount { get; }
        int ColCount { get; }

        double[][] Data { get; }
        int ConstCount { get; }

        double[] GetDataInputRow(int index);
        double[] GetTestDataInputRow(int index);

        double[] GetDataOutputCol(bool isTrainingData);

        double[] GetRandConsts();

        double GetRowOutput(int index);
        double[] GetRowOutputSoftmax(int index);

        double[] CalculateOutput(IChromosome chromosome, IParameters param, bool isTrainingData);

    }
}
