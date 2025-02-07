# 🚀 Social Media Downloader API

A powerful and lightning-fast API service that enables you to download content from 40+ social media platforms with ease! Built with Deno Fresh for maximum performance and reliability.

## ✨ Features

- 🎥 Download content from popular platforms:
  - TikTok (without watermark)
  - Instagram (posts, stories, reels)
  - Facebook (videos, photos)
  - YouTube (all qualities)
  - Twitter (tweets, media)
  - And 40+ more platforms!
- 🎨 Beautiful landing page with modern UI
- 📚 Interactive API documentation with Swagger UI
- 📱 Mobile-friendly responsive design
- 🔒 Secure and scalable architecture
- 🚦 Built-in rate limiting and error handling
- 📊 Real-time analytics and usage tracking
- 🤖 Telegram logging system with queue management

## 🛠️ Tech Stack

- ⚡ **Deno** - A modern runtime for JavaScript and TypeScript
- 🌊 **Fresh** - The next-gen web framework
- 🎨 **Tailwind CSS** - Utility-first CSS framework
- 📝 **TypeScript** - For type-safe code
- 🔄 **RESTful API** - Following best practices
- 📦 **Docker** - For containerization
- 🔍 **Swagger** - API documentation

## 📋 Prerequisites

- 🦕 Deno 1.37.0 or higher
- 🔑 A RapidAPI account and API key
- 🤖 A Telegram bot token and chat ID (for logging)

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

3. **Configure your `.env` file with the following:**
```env
RAPIDAPI_KEY=your_rapidapi_key_here
TELEGRAM_BOT_TOKEN=your_telegram_bot_token
TELEGRAM_CHAT_ID=your_telegram_chat_id
```

4. **Start the development server:**
```bash
deno task start
```

🌟 The application will be available at http://localhost:8000

## 📚 API Documentation

Visit http://localhost:8000/docs to explore our interactive API documentation.

### 🔥 Popular Endpoints

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

#### Check Usage Statistics
```http
GET /api/account/usage
X-API-Key: your_api_key_here
```

## 💰 Pricing Plans

- 🆓 **Free Tier**: 100 requests/day
- 💎 **Basic**: $9.99/month - 1,000 requests/day
- 🌟 **Pro**: $24.99/month - 5,000 requests/day
- 🏢 **Business**: $49.99/month - 15,000 requests/day
- 🚀 **Enterprise**: Custom pricing - Unlimited requests

## 🤝 Contributing

We love contributions! Here's how you can help:

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🌟 Star Us!

If you find this project useful, please give it a star ⭐! It helps us know that our work is valued and encourages us to create more awesome features!

## 📞 Support

- 📧 Email: support@apidownloader.com
- 💬 Discord: [Join our community](https://discord.gg/apidownloader)
- 🐦 Twitter: [@apidownloader](https://twitter.com/apidownloader)

## 🔮 Roadmap

- [ ] Add support for more platforms
- [ ] Implement WebSocket for real-time progress
- [ ] Add batch download feature
- [ ] Enhance error handling and retry mechanisms
- [ ] Implement caching system
- [ ] Add more payment options

## 🙏 Acknowledgments

- Thanks to all our contributors
- The amazing Deno community
- Our awesome users who provide valuable feedback

---
Made with ❤️ by the API Downloader Team
