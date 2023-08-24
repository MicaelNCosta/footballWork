namespace projeto1
{
    internal class MysqlParameter
    {
        private string v;
        private object brian;
        private object com;
        private string v1;
        private string v2;

        public MysqlParameter(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public MysqlParameter(string v, object brian, object com)
        {
            this.v = v;
            this.brian = brian;
            this.com = com;
        }
    }
}