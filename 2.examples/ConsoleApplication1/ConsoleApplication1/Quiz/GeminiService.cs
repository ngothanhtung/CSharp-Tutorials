using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ConsoleApplication1.Quiz
{
    internal class GeminiService
    {
        public string Grade(string teacherRoleName, string prompt, string rules)
        {
            var options = new RestClientOptions("https://generativelanguage.googleapis.com")
            {

            };

            var client = new RestClient(options);
            var request = new RestRequest("/v1beta/models/gemini-2.0-flash-lite:generateContent?key=AIzaSyAqIW63dDBEcUH9DDwI9EY5zn6BDY7jED4", Method.Post);
            request.AddHeader("Content-Type", "application/json");

            // Build the payload using C# objects and serialize to JSON
            var payload = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new
                            {
                                text = "Bạn là giáo viên môn " + teacherRoleName + ", hãy chấm câu trả lời sau trong cặp dấu [] sau: [" + prompt + "]. Yêu cầu: Nhận xét, giải thích ngắn gọn các nội dung sai. \nTrả lời song ngữ Anh - Việt gồm các thuộc tính: result_en, result_vi, explanation_en, explanation_vi. \n" + rules
                            }
                        }
                    }
                },
                generationConfig = new
                {
                    responseMimeType = "application/json"
                }
            };
            var body = JsonConvert.SerializeObject(payload, Formatting.Indented);

            // Attach serialized JSON to the request
            request.AddStringBody(body, "application/json");

            var response = client.Execute(request);

            // Parse the response and extract the text content
            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                var jsonResponse = JObject.Parse(response.Content);
                var textContent = jsonResponse["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();

                if (!string.IsNullOrEmpty(textContent))
                {
                    return textContent;
                }
                else
                {
                    return "No text content found in response.";
                }
            }
            else
            {
                return response.ErrorMessage;
            }
        }
    }
}
