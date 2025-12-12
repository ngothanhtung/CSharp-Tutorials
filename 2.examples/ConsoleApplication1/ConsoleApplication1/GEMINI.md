# LẤY GEMINI - API KEY
- Truy cập: https://aistudio.google.com/app/apikey
- Đăng nhập bằng Google Account
- Click "Create API Key"
- Copy API Key (dạng: AIzaSyXXXXXXXXXXXXXXXXXXXXXXXX)

# Gọi POSTMAN
- Mở Postman
- Tạo Request mới
- Chọn Method: POST
- URL: https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash-lite:generateContent?key=
- Thêm API Key vào cuối URL vừa copy
- Chọn Tab "Body"
- Chọn "raw"
- Chọn "JSON" ở dropdown bên phải
- Dán đoạn JSON mẫu bên dưới vào Body:

```json
{
    "contents": [
        {
            "parts": [
                {
                    "text": "Bạn là giáo viên môn lập trình, hãy chấm câu trả lời sau trong cặp dấu [] sau: [Lập trình hướng đối tượng không có tính kế thừa]. Yêu cầu nhận xét, giải thích ngắn gọn các nội dung sai. Trả lời song ngữ Anh - Việt gồm các thuộc tính: result_en, result_vi, explanation_en, explanation_vi"
                }
            ]
        }
    ],
    "generationConfig": {
        "temperature": 0.2,
        "maxOutputTokens": 800,
        "responseMimeType": "application/json"
    }
}

```
