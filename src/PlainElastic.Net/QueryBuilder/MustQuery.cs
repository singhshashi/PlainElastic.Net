namespace PlainElastic.Net.QueryBuilder
{
    public class MustQuery<T> : Query<T>
    {
        private const string queryTemplate = " \"must\": [ {0} ]";


        protected override string QueryTemplate
        {
            get { return queryTemplate; }
        }

    }
}