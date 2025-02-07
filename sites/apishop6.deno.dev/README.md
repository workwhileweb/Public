# 🚀 Social Media Downloader API

A powerful and reliable API service built with Deno Fresh that enables downloading content from 40+ social media platforms. Perfect for developers building content aggregation tools, social media managers, and backup solutions.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Deno](https://img.shields.io/badge/deno-1.37+-blue.svg)](https://deno.land)
[![API Status](https://img.shields.io/badge/API-Live-green.svg)](https://status.socialmediadownloader.api)

## ✨ Features

- 🌐 Support for 40+ social media platforms:
  - TikTok (with watermark removal)
  - Instagram (posts, stories, reels)
  - Facebook (videos, photos)
  - YouTube (videos, shorts)
  - Twitter/X (tweets, videos)
  - And many more!
- 🎨 Beautiful landing page with modern UI
- 📚 Interactive API documentation with Swagger UI
- 📱 Mobile-friendly responsive design
- 🔒 Secure authentication and rate limiting
- 📊 Real-time analytics and usage tracking
- 🤖 Telegram logging system with queue management
- ⚡ High-performance architecture
- 🔄 Automatic updates and platform compatibility

## 🛠️ Prerequisites

Before you begin, ensure you have the following:

- 🦕 Deno 1.37.0 or higher
- 🔑 A RapidAPI account and API key
- 🤖 A Telegram bot token and chat ID (for logging)
- 💻 Basic knowledge of TypeScript/JavaScript

## 🚀 Quick Start

1. **Clone the repository:**
```bash
git clone https://github.com/yourusername/social-media-downloader-api.git
cd social-media-downloader-api
```

2. **Set up environment variables:**
```bash
cp .env.example .env
```

3. **Configure your `.env` file:**
```env
RAPIDAPI_KEY=your_rapidapi_key_here
TELEGRAM_BOT_TOKEN=your_telegram_bot_token
TELEGRAM_CHAT_ID=your_telegram_chat_id
PORT=8000
```

4. **Start the development server:**
```bash
deno task start
```

The application will be available at `http://localhost:8000` 🎉

## 📚 API Documentation

Visit `http://localhost:8000/docs` to access the interactive API documentation.

### 🔥 Key Endpoints

#### Download Content
```http
POST /api/social/autolink
Content-Type: application/json
X-API-Key: your_api_key_here

{
  "url": "https://www.tiktok.com/@username/video/1234567890",
  "format": "mp4",
  "quality": "high"
}
```

## 📊 Response Format

```json
{
  "url": "original_url",
  "source": "platform_name",
  "author": {
    "username": "creator_username",
    "name": "Creator Name",
    "avatar": "avatar_url"
  },
  "title": "content_title",
  "thumbnail": "thumbnail_url",
  "duration": "video_duration",
  "medias": [
    {
      "url": "download_url",
      "quality": "1080p",
      "extension": "mp4",
      "type": "video",
      "size": 12345678
    }
  ],
  "statistics": {
    "likes": 1000000,
    "comments": 50000,
    "shares": 25000,
    "views": 5000000
  }
}
```

## 💰 Pricing Plans

| Feature | Basic | Pro | Business | Enterprise |
|---------|-------|-----|-----------|------------|
| Price | $9.99/mo | $24.99/mo | $49.99/mo | $99.99/mo |
| API Calls | 1,000/mo | 5,000/mo | 15,000/mo | 50,000/mo |
| Rate Limit | 5/sec | 10/sec | 20/sec | Unlimited |
| Platforms | 10 | 25 | All | All |
| Support | Basic | Priority | 24/7 | Custom SLA |

## 🔧 Development

### Running Tests
```bash
deno test
```

### Code Formatting
```bash
deno fmt
```

### Linting
```bash
deno lint
```

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🌟 Star History

[![Star History Chart](https://api.star-history.com/svg?repos=yourusername/social-media-downloader-api&type=Date)](https://star-history.com/#yourusername/social-media-downloader-api&Date)

## 📞 Support

- 📧 Email: support@socialmediadownloader.api
- 💬 Discord: [Join our community](https://discord.gg/socialmediadownloader)
- 🐦 Twitter: [@SMDownloaderAPI](https://twitter.com/SMDownloaderAPI)

## 🙏 Acknowledgments

- [Deno](https://deno.land) - The secure runtime for JavaScript and TypeScript
- [Fresh](https://fresh.deno.dev) - The next-gen web framework
- All our amazing contributors! 💖
