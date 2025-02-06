# Social Media Downloader API

A powerful API proxy service built with Deno Fresh that allows downloading
content from 40+ social media platforms.

## Features

- Download content from TikTok, Instagram, Facebook, YouTube, Twitter, and 40+
  more platforms
- Beautiful landing page with modern UI
- Interactive API documentation with Swagger UI
- Telegram logging system with queue management
- Rate limiting and error handling
- Modern, responsive design

## Prerequisites

- Deno 1.37.0 or higher
- A RapidAPI account and API key
- A Telegram bot token and chat ID (for logging)

## Setup

1. Clone the repository:

```bash
git clone <repository-url>
cd <repository-name>
```

2. Copy the environment configuration:

```bash
cp .env.example .env
```

3. Update the `.env` file with your credentials:

- Add your RapidAPI key
- Add your Telegram bot token
- Add your Telegram chat ID

4. Start the development server:

```bash
deno task start
```

The application will be available at http://localhost:8000

## API Documentation

Visit http://localhost:8000/docs to view the interactive API documentation.

## API Endpoints

### POST /api/social/autolink

Download content from social media platforms.

**Request Body:**

```json
{
  "url": "https://www.tiktok.com/@username/video/1234567890",
  "cookie": "optional_cookie_for_private_content"
}
```

**Response:**

```json
{
  "url": "original_url",
  "source": "platform_name",
  "author": "content_creator",
  "title": "content_title",
  "thumbnail": "thumbnail_url",
  "duration": "video_duration",
  "medias": [
    {
      "url": "download_url",
      "quality": "video_quality",
      "extension": "file_extension",
      "type": "content_type"
    }
  ]
}
```

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the LICENSE file for
details.
