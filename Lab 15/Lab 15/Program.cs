﻿using Lab_15;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;

int[] vector = new int[100000];
Random random = new Random();
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next(1, 1000);
}
int[] vectorCopy = vector.Select(number => number).ToArray();

Lab_15.Timer timer = new Lab_15.Timer();
timer.MeasureTask(vector);
vector = vectorCopy.Select(number => number).ToArray();
timer.MeasureTask(vector);
vector = vectorCopy.Select(number => number).ToArray();
timer.MeasureTask(vector);
vector = vectorCopy.Select(number => number).ToArray();
Console.WriteLine();
timer.MeasureAlgorithm(vector);
vector = vectorCopy.Select(number => number).ToArray();
timer.MeasureAlgorithm(vector);
vector = vectorCopy.Select(number => number).ToArray();
timer.MeasureAlgorithm(vector);
vector = vectorCopy.Select(number => number).ToArray();
Console.WriteLine();

Cancelation.ShowTaskCancelation(vector);
vector = vectorCopy.Select(number => number).ToArray();

Console.WriteLine(QuadraticEquation.SumQuadraticEquationSolutions(2, 16, 4));