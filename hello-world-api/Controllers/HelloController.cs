using Microsoft.AspNetCore.Mvc;

namespace hello_world_api.Controllers
{
    [Route("/")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ContentResult Get()
        {
            string html = @"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Hello Koieng</title>
                <style>
                    body {
                        display: flex;
                        justify-content: center;
                        align-items: center;
                        height: 100vh;
                        margin: 0;
                        background: linear-gradient(135deg, #4facfe, #00f2fe);
                        font-family: 'Arial', sans-serif;
                    }

                    h1 {
                        font-size: 5rem;
                        background: linear-gradient(90deg, #ff8a00, #e52e71, #9b00e8, #00e1ff);
                        background-size: 300% 300%;
                        -webkit-background-clip: text;
                        -webkit-text-fill-color: transparent;
                        animation: gradient-move 3s infinite alternate;
                        text-align: center;
                    }

                    @keyframes gradient-move {
                        0% { background-position: 0% 50%; }
                        100% { background-position: 100% 50%; }
                    }
                </style>
            </head>
            <body>
                <h1>HELLO Koieng 🚀</h1>
                <h2>Welcome to the Hello Koieng API!</h2>
            </body>
            </html>";

            return new ContentResult
            {
                Content = html,
                ContentType = "text/html"
            };
        }
    }
}
