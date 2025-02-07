# 🚀 Social Media Downloader API

A powerful and reliable API service for downloading content from 40+ social media platforms. Built with Deno Fresh for maximum performance and reliability. 🌟

## ✨ Features

- 📥 Download content from popular platforms:
  - TikTok (videos, music)
  - Instagram (posts, stories, reels)
  - Facebook (videos, photos)
  - YouTube (videos, shorts)
  - Twitter (tweets, media)
  - And 40+ more platforms!
- 🎨 Beautiful landing page with modern UI and animations
- 📚 Interactive API documentation with Swagger UI
- 📱 Mobile-first, responsive design
- 🔒 Secure authentication and rate limiting
- 📊 Real-time analytics and usage statistics
- 🤖 Telegram logging system with queue management
- ⚡ High-performance architecture
- 🛡️ Enterprise-grade error handling
- 🌐 Global CDN for fast content delivery

## 🛠️ Prerequisites

Before you begin, ensure you have the following installed:

- 🦕 Deno 1.37.0 or higher
- 🔑 A RapidAPI account and API key
- 🤖 A Telegram bot token and chat ID (for logging)

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

3. **Configure your credentials in `.env`:**

```env
# API Configuration
RAPIDAPI_KEY=your_rapidapi_key_here
API_RATE_LIMIT=100

# Telegram Configuration
TELEGRAM_BOT_TOKEN=your_bot_token_here
TELEGRAM_CHAT_ID=your_chat_id_here

# Security
JWT_SECRET=your_jwt_secret_here
CORS_ORIGINS=https://yourdomain.com

# Cache Configuration
REDIS_URL=redis://localhost:6379
CACHE_TTL=3600
```

4. **Start the development server:**

```bash
deno task start
```

The application will be available at http://localhost:8000 🎉

## 📚 API Documentation

Visit http://localhost:8000/docs to view the interactive API documentation.

### 🔥 Popular Endpoints

#### Download Content

```http
POST /api/social/autolink
Content-Type: application/json
X-API-Key: your_api_key_here

{
  "url": "https://www.tiktok.com/@username/video/1234567890",
  "quality": "high",
  "format": "mp4"
}
```

#### Response Example

```json
{
  "url": "https://www.tiktok.com/@username/video/1234567890",
  "source": "TikTok",
  "author": {
    "username": "username",
    "name": "User Name",
    "avatar": "https://p16-sign.tiktokcdn-us.com/avatar.jpeg"
  },
  "title": "Check out this amazing video! #viral",
  "thumbnail": "https://p16-sign.tiktokcdn-us.com/thumbnail.jpeg",
  "duration": "00:30",
  "medias": [
    {
      "url": "https://download.tiktok.com/video.mp4",
      "quality": "1080p",
      "extension": "mp4",
      "type": "video",
      "size": 12345678,
      "width": 1080,
      "height": 1920
    }
  ]
}
```

## 💰 Pricing Plans

We offer flexible pricing plans to suit your needs:

- 🌱 **Basic** - $9.99/month
  - 1,000 API calls/month
  - 5 requests/second
  - Basic support
  - 10 platforms supported

- 💼 **Pro** - $24.99/month
  - 5,000 API calls/month
  - 10 requests/second
  - Priority support
  - 25 platforms supported

- 🏢 **Business** - $49.99/month
  - 15,000 API calls/month
  - 20 requests/second
  - 24/7 priority support
  - All platforms supported

- 🏛️ **Enterprise** - $99.99/month
  - 50,000 API calls/month
  - Unlimited requests/second
  - Custom support SLA
  - Custom solutions

## 🔧 Development

### Project Structure

```
├── 📁 routes/            # API routes and endpoints
├── 📁 components/        # Reusable UI components
├── 📁 islands/          # Interactive components
├── 📁 static/           # Static assets
├── 📁 utils/            # Helper functions
├── 📁 services/         # Business logic
├── 📁 middleware/       # Custom middleware
└── 📁 config/           # Configuration files
```

### Running Tests

```bash
deno test
```

### Building for Production

```bash
deno task build
```

## 🤝 Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🌟 Support

- 📧 Email: support@socialmediadownloader.api
- 💬 Discord: [Join our community](https://discord.gg/socialmediadownloader)
- 🐦 Twitter: [@SMDownloaderAPI](https://twitter.com/SMDownloaderAPI)
- 📚 Documentation: [docs.socialmediadownloader.api](https://docs.socialmediadownloader.api)

## 🙏 Acknowledgments

- [Deno](https://deno.land/) - The secure runtime for JavaScript and TypeScript
- [Fresh](https://fresh.deno.dev/) - The next-gen web framework
- [Preact](https://preactjs.com/) - Fast 3kB alternative to React
- [Tailwind CSS](https://tailwindcss.com/) - A utility-first CSS framework
