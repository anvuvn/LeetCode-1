// Source : https://leetcode.com/problems/sudoku-solver/ 
// Author : codeyu 
// Date : Monday, October 17, 2016 7:38:31 PM 

/**********************************************************************************
*
* Write a program to solve a Sudoku puzzle by filling the empty cells.
* 
* Empty cells are indicated by the character '.'.
* 
* You may assume that there will be only one unique solution.
* 
* 
* 
* A sudoku puzzle...
* 
* 
* 
* 
* ...and its solution numbers marked in red.
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution037 
    {
        public static char[,] SolveSudoku(char[,] board) 
        {
            if(board.Length != 81 || board.GetLength(0) != 9) 
            {
                return null;
            }           
            SolveSudoku(board,0,0);
            return board;
        }
        private static bool SolveSudoku(char[,] board, int i, int j)
        {
            if(i == 9) return true;
            if(j >= 9) return SolveSudoku(board,i + 1, 0);
            if(board[i,j] == '.')
            {
                for(int k=1;k<=9;k++)  
                {  
                    board[i,j] = (char)(k+'0');  
                    if(IsValid(board,i,j))  
                    {  
                        if(SolveSudoku(board,i,j+1))  
                            return true;  
                    }   
                }  
            }  
            else  
            {  
                return SolveSudoku(board,i,j+1);  
            }  
            board[i,j] = '.';
            return false;  
        }
        private static bool IsValid(char[,] board, int i, int j)  
        {  
            for(int k=0;k<9;k++)  
            {  
                if(k!=j && board[i,k]==board[i,j])  
                    return false;  
            }  
            for(int k=0;k<9;k++)  
            {  
                if(k!=i && board[k,j]==board[i,j])  
                    return false;  
            }          
            for(int row = i/3*3; row<i/3*3+3; row++)  
            {  
                for(int col=j/3*3; col<j/3*3+3; col++)  
                {  
                    if((row!=i || col!=j) && board[row,col]==board[i,j])  
                        return false;  
                }  
            }  
            return true;  
        }  
    }
}

