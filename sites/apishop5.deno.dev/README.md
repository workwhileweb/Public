# 🚀 Social Media Downloader API

A powerful and lightning-fast API service for downloading content from 40+ social media platforms! Built with Deno Fresh for maximum performance and reliability. ⚡

## ✨ Features

- 📥 Download content from popular platforms:
  - TikTok (without watermark)
  - Instagram (posts, stories, reels)
  - Facebook (videos, photos)
  - YouTube (all qualities)
  - Twitter/X (tweets, media)
  - Telegram (messages, media)
  - And 35+ more platforms!
- 🎨 Beautiful landing page with modern UI
- 📚 Interactive API documentation with Swagger UI
- 🔔 Real-time Telegram logging system
- ⚡ High-performance queue management
- 🛡️ Built-in rate limiting and error handling
- 📱 Responsive design for all devices
- 🔒 Secure API key authentication

## 🛠️ Prerequisites

Before you begin, ensure you have the following:

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

3. **Configure your `.env` file with:**
```env
RAPIDAPI_KEY=your_api_key_here
TELEGRAM_BOT_TOKEN=your_bot_token_here
TELEGRAM_CHAT_ID=your_chat_id_here
```

4. **Start the development server:**
```bash
deno task start
```

Your API will be running at `http://localhost:8000` 🎉

## 📚 API Documentation

Visit `http://localhost:8000/docs` to explore our interactive API documentation.

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

## 💰 Pricing Plans

We offer flexible pricing plans to suit your needs:

- 🆓 **Basic** - $9.99/month
  - 1,000 API calls/month
  - 5 requests/second
  - Basic support
  - 10 platforms

- 🥈 **Pro** - $24.99/month
  - 5,000 API calls/month
  - 10 requests/second
  - Priority support
  - 25 platforms

- 🥇 **Business** - $49.99/month
  - 15,000 API calls/month
  - 20 requests/second
  - 24/7 priority support
  - All platforms

- 💎 **Enterprise** - $99.99/month
  - 50,000 API calls/month
  - Unlimited requests/second
  - Custom support SLA
  - Custom solutions

## 🤝 Contributing

We welcome contributions! Here's how you can help:

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🌟 Support

Need help? We're here for you!

- 📧 Email: support@socialmediadownloader.com
- 💬 Discord: [Join our community](https://discord.gg/socialmediadownloader)
- 📱 Twitter: [@SMDownloader](https://twitter.com/SMDownloader)

## ⭐ Star Us!

If you find this project useful, please give it a star! It helps us know that our work is valued and encourages us to make more improvements.

---

Made with ❤️ by the Social Media Downloader Team
