# 🚀 Social Media Downloader API

A powerful and reliable API service for downloading content from 40+ social media platforms. Built with Deno Fresh for maximum performance and reliability. 🌟

## ✨ Features

- 📱 Support for 40+ platforms including:
  - TikTok (videos, photos, music)
  - Instagram (posts, stories, reels, IGTV)
  - Facebook (videos, photos, stories)
  - YouTube (videos, shorts, live streams)
  - Twitter (tweets, videos, spaces)
  - And many more!
- 🎨 Beautiful landing page with modern UI
- 📚 Interactive API documentation with Swagger UI
- 📊 Real-time analytics and usage monitoring
- 🔒 Secure authentication and rate limiting
- 🚦 Advanced queue management system
- 📱 Mobile-friendly responsive design
- 🔄 Automatic format conversion
- 💬 Telegram logging and notification system

## 🛠️ Tech Stack

- **Runtime**: Deno 1.37.0+
- **Framework**: Fresh
- **UI**: Tailwind CSS
- **Documentation**: Swagger/OpenAPI 3.0
- **Monitoring**: Custom analytics dashboard
- **Logging**: Telegram integration

## 📋 Prerequisites

Before you begin, ensure you have the following:

- 🦕 Deno 1.37.0 or higher installed
- 🔑 A RapidAPI account and API key
- 🤖 A Telegram bot token and chat ID (for logging)
- 💻 Basic knowledge of TypeScript/JavaScript

## 🚀 Quick Start

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/social-media-downloader-api.git
   cd social-media-downloader-api
   ```

2. **Set up environment variables**:
   ```bash
   cp .env.example .env
   ```
   Edit `.env` with your credentials:
   ```env
   RAPIDAPI_KEY=your_rapidapi_key
   TELEGRAM_BOT_TOKEN=your_telegram_bot_token
   TELEGRAM_CHAT_ID=your_telegram_chat_id
   ```

3. **Start the development server**:
   ```bash
   deno task start
   ```
   The application will be available at http://localhost:8000 🎉

## 📚 API Documentation

Visit http://localhost:8000/docs to explore our interactive API documentation.

### 🔥 Key Endpoints

#### POST /api/social/autolink
Download content from any supported platform.

**Request**:
```json
{
  "url": "https://www.tiktok.com/@username/video/1234567890",
  "cookie": "optional_cookie_for_private_content"
}
```

**Response**:
```json
{
  "url": "original_url",
  "source": "tiktok",
  "author": {
    "name": "username",
    "profile_url": "https://tiktok.com/@username",
    "avatar_url": "https://..."
  },
  "title": "Video title",
  "thumbnail": "thumbnail_url",
  "duration": "00:00:30",
  "medias": [
    {
      "url": "download_url",
      "quality": "1080p",
      "extension": "mp4",
      "type": "video"
    }
  ]
}
```

## 💰 Pricing Plans

- 🆓 **Free**: 100 requests/day
- 💎 **Basic**: $9.99/month - 1,000 requests/day
- 🌟 **Pro**: $24.99/month - 5,000 requests/day
- 🚀 **Business**: $49.99/month - 15,000 requests/day
- 🏢 **Enterprise**: Custom pricing - Unlimited requests

## 📈 Performance

- ⚡ Average response time: <100ms
- 🔄 Success rate: 99.9%
- 🌐 Global CDN distribution
- 🛡️ DDoS protection included

## 🔒 Security

- 🔑 API key authentication
- 🛡️ Rate limiting per API key
- 📝 Request logging and monitoring
- 🔐 HTTPS encryption
- 🚫 IP blocking for abuse prevention

## 🤝 Contributing

We welcome contributions! Here's how you can help:

1. 🍴 Fork the repository
2. 🌿 Create a feature branch
3. 💻 Make your changes
4. 🧪 Run tests
5. 📝 Submit a pull request

Please read our [Contributing Guidelines](CONTRIBUTING.md) for details.

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Support

- 📧 Email: support@socialmediadownloader.com
- 💬 Discord: [Join our server](https://discord.gg/socialmediadownloader)
- 🐦 Twitter: [@SMDownloaderAPI](https://twitter.com/SMDownloaderAPI)

## 🙏 Acknowledgments

- Thanks to all our contributors 👥
- Built with [Deno](https://deno.land) 🦕
- Powered by [Fresh](https://fresh.deno.dev) 🍋

---

Made with ❤️ by the Social Media Downloader Team
