using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Primary
{
    class Seqadv
    {

        private string _idcode;
        private string _resname;
        private char _chainid;
        private uint _seqnum;
        private char _icode;
        private string _database;
        private string _dbaccession;
        private string _dbres;
        private uint _dbseq;
        private string _conflict;

        public Seqadv(string idcode, string resname, char chainid, uint seqnum, char icode, string database, string dbaccession, string dbres, uint dbseq, string conflict)
        {
            _idcode = idcode;
            _resname = resname;
            _chainid = chainid;
            _seqnum = seqnum;
            _icode = icode;
            _database = database;
            _dbaccession = dbaccession;
            _dbres = dbres;
            _dbseq = dbseq;
            _conflict = conflict;
        }

        public string GetIdCode() { return _idcode; }
        public string GetResName() { return _resname; }
        public char GetChainId() { return _chainid; }
        public uint GetSeqNum() { return _seqnum; }
        public char GetICode() { return _icode; }
        public string GetDatabase() { return _database; }
        public string GetDbAcession() { return _dbaccession; }
        public string GetDbRes() { return _dbres; }
        public uint GetDbSeq() { return _dbseq; }
        public string GetConflict() { return _conflict; }
    }
}
