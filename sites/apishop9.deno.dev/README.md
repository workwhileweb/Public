# 🚀 Social Media Downloader API

A powerful and lightning-fast API service for downloading content from 40+ social media platforms! Built with Deno Fresh for maximum performance and reliability. 🌟

## ✨ Features

- 📥 Download content from popular platforms:
  - TikTok (without watermark)
  - Instagram (posts, stories, reels)
  - Facebook (videos, photos)
  - YouTube (all qualities)
  - Twitter/X (tweets, media)
  - And 40+ more platforms!
- 🎨 Beautiful landing page with modern UI
- 📚 Interactive API documentation with Swagger UI
- 📊 Real-time analytics and usage statistics
- 🔒 Secure authentication and rate limiting
- 🚦 Smart queue management system
- 📱 Mobile-friendly responsive design
- 🔄 Automatic format conversion
- 💬 24/7 Technical support

## 🛠️ Prerequisites

Before you begin, ensure you have the following installed:
- 🦕 Deno 1.37.0 or higher
- 🔑 RapidAPI account and API key
- 🤖 Telegram bot token and chat ID (for logging)

## 🚀 Quick Start

1. **Clone the repository:**
```bash
git clone <repository-url>
cd <repository-name>
```

2. **Set up environment variables:**
```bash
cp .env.example .env
```

3. **Configure your `.env` file with the following:**
```env
RAPIDAPI_KEY=your_api_key_here
TELEGRAM_BOT_TOKEN=your_bot_token_here
TELEGRAM_CHAT_ID=your_chat_id_here
PORT=8000
```

4. **Start the development server:**
```bash
deno task start
```

Visit http://localhost:8000 to see your application in action! 🎉

## 📚 API Documentation

Our comprehensive API documentation is available at http://localhost:8000/docs

### 🔥 Key Endpoints

#### Download Content
```http
POST /api/autolink/2
Content-Type: application/json
X-API-Key: your_api_key_here

{
  "url": "https://www.tiktok.com/@username/video/1234567890",
  "quality": "high"
}
```

#### Get Metadata
```http
GET /api/metadata?url=https://www.instagram.com/p/abcd1234
X-API-Key: your_api_key_here
```

## 💰 Pricing Plans

We offer flexible pricing plans to suit your needs:

- 🆓 **Free Tier**: 100 requests/day
- 💎 **Basic**: $9.99/month - 1,000 requests/day
- 🌟 **Pro**: $24.99/month - 5,000 requests/day
- 🏢 **Business**: $49.99/month - 15,000 requests/day
- 🚀 **Enterprise**: Custom pricing - Unlimited requests

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

We welcome contributions! Here's how you can help:

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🌟 Star Us!

If you find this project helpful, please consider giving it a star! ⭐

## 📞 Support

- 📧 Email: support@socialmediadownloader.com
- 💬 Discord: [Join our community](https://discord.gg/socialmediadownloader)
- 🐦 Twitter: [@SMDownloader](https://twitter.com/SMDownloader)

## 🔮 Roadmap

- [ ] Add support for more platforms
- [ ] Implement batch downloading
- [ ] Add AI-powered content analysis
- [ ] Develop mobile apps
- [ ] Introduce webhook notifications
- [ ] Add custom branding options

## 🙏 Acknowledgments

- Thanks to the Deno community
- All our amazing contributors
- Our dedicated users

---
Made with ❤️ by the Social Media Downloader Team
