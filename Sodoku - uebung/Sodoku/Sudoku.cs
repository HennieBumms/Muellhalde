using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SudokuClass {
    public class Sudoku {
        private readonly int[][] sudokuData;
        private bool result = true;

        public Sudoku(int[][] sudokuData) {
            this.sudokuData = sudokuData;
        }

        public bool IsValid() {
            checkValidField();
            if (result) {
                checkRows();
            }

            if (result) {
                checkColumns();
            }

            if (result) {
                checkBoxes();
            }

            return result;
        }

        private void checkValidField() {
            foreach (int[] row in sudokuData) {
                if (row.Length != sudokuData.Length) {
                    result = false;
                }
            }
        }

        private void checkBoxes() {
            HashSet<int> box = new HashSet<int>();
            int size = getBoxSize();
            int boxX = size;
            int boxY = size;
            for (int n = 0; n < sudokuData.Length && result; n++) {
                for (int i = boxY - size; i < boxY; i++) {
                    for (int k = boxX - size; k < boxX; k++) {
                        box.Add(sudokuData[i][k]);
                    }
                }

                if (box.Count != Math.Pow(size, 2)) {
                    result = false;
                }

                box.Clear();
                boxX = boxY >= Math.Pow(size, 2) ? boxX + size : boxX;
                boxY = boxY < Math.Pow(size, 2) ? boxY + size : size;
            }
        }

        private int getBoxSize() {
            return sudokuData.Length == 9 ? 3 : 2;
        }

        private void checkColumns() {
            int[] column = new int[sudokuData.Length];
            for (int k = 0; k < sudokuData.Length; k++) {
                for (int i = 0; i < sudokuData.Length; i++) {
                    column[i] = sudokuData[i][k];
                }

                if (new HashSet<int>(column).Count != column.Length) {
                    result = false;
                }
                column = new int[sudokuData.Length];
            }
        }

        private void checkRows() {
            foreach (int[] row in sudokuData) {
                if (new HashSet<int>(row).Count != row.Length) {
                    result = false;
                }
            }
        }
    }
}