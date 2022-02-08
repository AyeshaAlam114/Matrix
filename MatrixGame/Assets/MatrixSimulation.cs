using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixSimulation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Matrix matrixA = new Matrix(3,3);   //(m,n)
        matrixA.PrintMatrix();
        int[] valuesForMatrixA;              // length should be equal to mxn
        valuesForMatrixA = new int[]{ 1,2,3,
                                     4,5,6,
                                     7,8,9};
        matrixA.SetMatrix(3, 3, valuesForMatrixA);
        matrixA.PrintMatrix();
        //matrixA.SetColumnOfMatrix(1, new List<int> { 1,1,1});
        //matrixA.PrintMatrix();
        //matrixA.SwapColumns(1, 2);
        //matrixA.PrintMatrix();
        //matrixA.SwapRows(0,1);
        //matrixA.PrintMatrix();
        //Debug.Log(matrixA.IsASquareMatrix());

        //Matrix matrixB = new Matrix(3, 3);   //(m,n)
        //matrixB.PrintMatrix();
        //int[] valuesForMatrixB;              // length should be equal to mxn
        //valuesForMatrixB = new int[]{ 1,2,3,
        //                             4,5,6,
        //                             7,8,9};
        //matrixB.SetMatrix(3, 3, valuesForMatrixB);
        //matrixB.PrintMatrix();

        //Debug.Log(matrixB.IsASquareMatrix());

        //matrixA.SetMatrixOf(1);
        //matrixA.PrintMatrix();
        //matrixA.SetMatrixOf(2);
        //matrixA.PrintMatrix();

        //matrixA.SetRowOfMatrixTo(1, 5);
        //matrixA.PrintMatrix();
        //matrixA.SetRowOfMatrixTo(2, 6);
        //matrixA.PrintMatrix();
        //matrixA.SetColumnOfMatrixTo(1, 3);
        //matrixA.PrintMatrix();
        //matrixA.SetPrimaryDiagnalTo(1);
        //matrixA.PrintMatrix();
        //matrixA.SetSecondaryDiagnalTo(7);
        //matrixA.PrintMatrix();
        //matrixA.SetRowOfMatrixTo(2, 6);
        //matrixA.PrintMatrix();
        //Debug.Log( matrixA.IsRowSame(2));
        //Debug.Log(matrixA.IsColumnSame(2));
        //matrixA.SetColumnOfMatrixTo(1, 3);
        //matrixA.PrintMatrix();
        //Debug.Log(matrixA.IsColumnSame(1));
        //for(int i=0;i<3;i++)
        //Debug.Log(matrixA.GetPrimaryDiagnal()[i]);

        //for (int i = 0; i < 3; i++)
        //    Debug.Log(matrixA.GetSecondaryDiagnal()[i]);

        //matrixA.SwapColumns(0,1);
        //matrixA.PrintMatrix();

        //matrixA.AddMatrix(matrixB).PrintMatrix();

        Matrix matrixC = new Matrix(3, 2);   //(m,n)
        matrixC.PrintMatrix();
        int[] valuesForMatrixB;              // length should be equal to mxn
        valuesForMatrixB = new int[]{ 1,2,
                                     4,5,
                                     7,8};
        matrixC.SetMatrix(3, 2, valuesForMatrixB);
        matrixC.PrintMatrix();
        matrixA.MultiplyMatrixWith(matrixC);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
