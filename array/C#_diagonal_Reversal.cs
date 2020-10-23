// C# program to print all elements
// of given matrix in diagonal order
using System;
 
class GFG {
     
    static int ROW = 5;
    static int COL = 4;
 
     
    // The main function that prints given
    // matrix in diagonal order
    static void diagonalOrder(int [,]matrix) {
     
        // There will be ROW+COL-1 lines in the output
        for (int line = 1; line <= (ROW + COL - 1); line++)
        {
     
            // Get column index of the first element
            // in this line of output.The index is 0 
            // for first ROW lines and line - ROW for 
            // remaining lines
            int start_col = Math.Max(0, line - ROW);
         
            // Get count of elements in this line. The
            // count of elements is equal to minimum of 
            // line number, COL-start_col and ROW 
            int count = Math.Min(line, Math.Min(
                                  (COL - start_col), ROW));
     
            // Print elements of this line 
            for (int j = 0; j < count; j++)
                Console.Write(matrix[ Math.Min(ROW, line) 
                            - j - 1, start_col + j] + " ");
         
            // Print elements of next diagonal on next line
            Console.WriteLine();
        }
    }
     
    // Utility function to print a matrix
    static void printMatrix(int [,]matrix) {
        for (int i = 0; i < ROW; i++) {
            for (int j = 0; j < COL; j++)
                Console.Write(matrix[i,j] + " ");
                 
            Console.WriteLine("\n");
        }
    }
     
    // Driver code
    public static void Main() {
        int [,]M = {{1, 2, 3, 4},
                    {5, 6, 7, 8},
                    {9, 10, 11, 12},
                    {13, 14, 15, 16}, 
                    {17, 18, 19, 20}};
                     
        Console.Write("Given matrix is \n");
        printMatrix(M);
     
        Console.Write("\nDiagonal printing"
                     + " of matrix is \n");
                      
        diagonalOrder(M);
    }
}
 // By - Akash Pant
