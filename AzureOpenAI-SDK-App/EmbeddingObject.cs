namespace AzureOpenAI_SDK_App
{
    public class EmbeddingObject
    {
        public string text_value { get; set; }
        public Data text_data { get; set; }
        public double score { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public EmbeddingObject(string text_value, Data text_data, double score, string id)
        {
            this.text_value=text_value;
            this.text_data=text_data;
            this.score=score;
            this.id =id;
        }
        public EmbeddingObject() { }
    }

    public class Data
    {
        public string _object { get; set; }
        public int index { get; set; }
        public List<float> embedding { get; set; }
        public Data() { }
    }
}
