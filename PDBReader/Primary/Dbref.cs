using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Primary
{
    class Dbref
    {

        private string _idcode;
        private char _chainid;
        private uint _seqbegin;
        private char _insertbegin;
        private uint _seqend;
        private char _insertend;
        private string _database;
        private string _dbacession;
        private string _dbidcode;
        private uint _dbseqbegin;
        private char _idbnsbeg;
        private uint _dbseqend;
        private char _dbinsend;

        public Dbref(string idcode, char chainid, uint seqbegin, char insertbegin, uint seqend, char insertend, string database, string dbacession, string dbidcode, uint dbseqbegin, char idbnsbeg, uint dbseqend, char dbinsend)
        {
            _idcode = idcode;
            _chainid = chainid;
            _seqbegin = seqbegin;
            _insertbegin = insertbegin;
            _seqend = seqend;
            _insertend = insertend;
            _database = database;
            _dbacession = dbacession;
            _dbidcode = dbidcode;
            _dbseqbegin = dbseqbegin;
            _idbnsbeg = idbnsbeg;
            _dbseqend = dbseqend;
            _dbinsend = dbinsend;
        }
    }
}
