## Краткий обзор
**vue-net-news** — это приложение для просмотра новостей.


## 📦 Технологии

- ASP.NET Core 9 (Web API)
- PostgreSQL
- Vue.Js 3 (TypeScript)
- Pinia
- Tailwind CSS
## 🚀 Как запустить

### Backend

1. Перейти в папку `api`:
   ```bash
   cd api
   ```

2. Установить зависимости:
   ```bash
   dotnet restore
   ```

3. Заполнить базу данных mock данными:
   ```bash
   dotnet run -- seed
   ```

4. Запустить сервер:
   ```bash
   dotnet run
   ```

### Frontend

1. Перейти в папку `client`:
   ```bash
   cd client
   ```

2. Установить зависимости:
   ```bash
   bun install
   ```

3. Запустить фронтенд:
   ```bash
   bun run dev
   ```
