using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadoku.Classes
{
    internal class Tile
    {
        private bool ReadOnly;
        private bool isValid;
        private int AssignedNumber;
        private int AssignedBlock;
        private int Column;
        private int Row;

        public Tile(int _AssignedBlock, int _Column, int _row)
        {
            AssignedBlock = _AssignedBlock;
            Column = _Column;
            Row = _row;
        }


        public void SetReadOnlyT()
        {
            ReadOnly = true;
        }

        public void SetIsValid(bool _isValid)
        {
            isValid = _isValid;
        }

        public bool IsReadOnly() { 
            return ReadOnly;
        }

        public bool IsValid()
        {
            return isValid;
        }

        public void SetAssignedNumber(int _assignedNumber) {
            if (!ReadOnly)
            {
                AssignedNumber = _assignedNumber;
            }
        }

        public int GetAssignedNumber()
        {
            return AssignedNumber;
        }

        public int GetAssignedBlock() {
            return AssignedBlock;
        }

        public int GetColumn() { 
            return Column;
        }

        public int GetRow()
        {
            return Row;
        }


    }
}
