﻿namespace EjemploEntity.DTOs
{
    // ChuckNorrisJokesDto myDeserializedClass = JsonConvert.DeserializeObject<ChuckNorrisJokesDto>(myJsonResponse);
    public class ChuckNorrisJokesDto
    {
        public List<object> categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }

    // CnJokesByQueryDto myDeserializedClass = JsonConvert.DeserializeObject<CnJokesByQueryDto>(myJsonResponse);
    public class Result
    {
        public List<string> categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }

    public class CnJokesByQueryDto
    {
        public int total { get; set; }
        public List<Result> result { get; set; }
    }
}
