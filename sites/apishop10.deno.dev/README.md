# 🚀 Social Media Downloader API

A powerful and reliable API service for downloading content from 40+ social media platforms. Built with Deno Fresh for maximum performance and reliability! 💪

## ✨ Features

- 📱 Support for 40+ social media platforms:
  - TikTok (with watermark removal)
  - Instagram (posts, stories, reels)
  - Facebook (videos, photos)
  - YouTube (all qualities)
  - Twitter/X (tweets, media)
  - And many more!
- 🎨 Beautiful landing page with modern UI
- 📚 Interactive API documentation with Swagger UI
- 📊 Telegram logging system with queue management
- 🛡️ Rate limiting and error handling
- 💅 Modern, responsive design
- 🔒 Secure and scalable architecture

## 🛠️ Prerequisites

Before you begin, ensure you have the following installed:
- 🦕 Deno 1.37.0 or higher
- 🔑 A RapidAPI account and API key
- 🤖 A Telegram bot token and chat ID (for logging)

## 🚀 Quick Start

### 1. Clone the Repository

```bash
git clone <repository-url>
cd <repository-name>
```

### 2. Configure Environment Variables

```bash
cp .env.example .env
```

Update the `.env` file with your credentials:
```env
RAPIDAPI_KEY=your_rapidapi_key_here
TELEGRAM_BOT_TOKEN=your_telegram_bot_token
TELEGRAM_CHAT_ID=your_telegram_chat_id
```

### 3. Start the Development Server

```bash
deno task start
```

The application will be available at http://localhost:8000 🎉

## 📚 API Documentation

Visit http://localhost:8000/docs to view the interactive API documentation.

### Example API Request

```javascript
const response = await fetch('https://your-api.com/api/social/autolink', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
    'X-API-Key': 'your_api_key_here'
  },
  body: JSON.stringify({
    url: 'https://www.tiktok.com/@username/video/1234567890',
    format: 'mp4',
    quality: 'high'
  })
});

const data = await response.json();
console.log(data);
```

## 💰 Pricing Plans

We offer flexible pricing plans to suit your needs:

- 🆓 **Basic**: 1,000 API calls/month - $9.99/month
- 💼 **Pro**: 5,000 API calls/month - $24.99/month
- 🌟 **Business**: 15,000 API calls/month - $49.99/month
- 🏢 **Enterprise**: Custom pricing with dedicated support

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
- 📚 Documentation: [Read the docs](https://docs.socialmediadownloader.com)
- 🐛 Issues: [Report a bug](https://github.com/yourusername/social-media-downloader/issues)

## 🙏 Acknowledgments

- Thanks to the Deno community for the amazing framework
- All our contributors and supporters
- The open-source projects that made this possible

---
Made with ❤️ by the Social Media Downloader Team
