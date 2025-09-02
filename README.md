# Texting App - Angular - ASP.NET Core

I need a way to remind myself of important life events and daily tasks that do not get lost in the clutter of my email inbox, or missed on my calendar. I personally find text messages, and my text app to be extremely quick to interact with and I think it might be the most powerful way to remind someone else of something important, except I can't set regular texts to be sent to myself. Also my iPhone's text messaging app auto sorts unread messages and threads to the top of the page, email doesn't do this, and push notifications don't have an organizing page of read/unread messages. So this app is a way for me and others to harness the power of sms communication for my own / their own needs, given that it already has a simple and easy to use interface that organizes unread messages appropriately.

My first item is to be able to get regular sms reminders to tell my wife she is beautiful. She needs words of affirmation as her one of her love languages and unfortunately I am terrible at reminding myself to say nice things to her throughout the day, also our lives our extremely busy with young kids and animals to take care of. Luckily she will never visit my github account so I can safely talk about this here. I previously tried setting recurring calendar events to remind myself to tell her words of affirmation, but it really just polluted my calendar, and phones tend to have many push notifications as well that pile up.

This repo is a work in progress, but feel free to email me any suggestions. Will need to add instructions to get your own Twilio API key and add it to the project so that you can run it yourself.

## Features 🛠️

✅ **Latest Angular 20** – Stay up-to-date with the newest Angular features.
✅ **Angular Material** – Build beautiful, responsive UIs with Material Design.
✅ **Unit Testing with Jest** – Fast and reliable testing for your components.
✅ **End-to-End Testing with Cypress** – Ensure your app works flawlessly from start to finish.
✅ **Internationalization with Transloco** – Easily support multiple languages.
✅ **Auto Documentation with Compodoc** – Keep your codebase well-documented.
✅ **Component Examples with Storybook** – Showcase and test your components in isolation.
✅ **Bundle Analysis with Source Map Explorer** – Optimize your app's performance.
✅ **Docker Support** – Simplify deployment and containerization.
✅ **Code Quality Tools** – ESLint, Prettier, and Commit Linting for clean, consistent code.
✅ **Security Audits with AuditJS** – Keep your dependencies secure.
✅ **Auto-Generated CHANGELOG** – Track changes effortlessly with auto-changelog.
✅ **Tailwind CSS Integration** – Utilize a utility-first CSS framework to create sleek, responsive designs efficiently.

## Quick Start 🚀

### Installation

```bash
# Clone the repository
git clone https://github.com/wlucha/angular-starter
cd angular-starter

# Install dependencies
npm install --force

# Start the development server
npm run start

# Open your browser at http://localhost:4200
```

### Docker Deployment

```bash
# Build the Docker image
docker build . -t angular-starter

# Run the Docker container
docker run -p 3000:80 angular-starter
```

## Demo & Deployment 🖥️

- **Deploy to Heroku**: [![Deploy to Heroku](https://www.herokucdn.com/deploy/button.png)](https://heroku.com/deploy)

## Commands Overview 📜

Here are some of the most useful commands:

| Command             | Description                                      |
| ------------------- | ------------------------------------------------ |
| `npm run start`     | Start the development server.                    |
| `npm run lint`      | Lint the project for code quality.               |
| `npm run test`      | Run unit tests with Jest.                        |
| `npm run build`     | Build the project for production.                |
| `npm run compodoc`  | Generate documentation with Compodoc.            |
| `npm run storybook` | Launch Storybook for component examples.         |
| `npm run audit`     | Audit dependencies for security vulnerabilities. |
| `npm run prettier`  | Format the entire project with Prettier.         |
