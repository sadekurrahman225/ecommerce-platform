# Build Angular app
FROM node:20 AS build
WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .
RUN npm run build --configuration=development

# Serve with nginx
FROM nginx:1.25-alpine
COPY --from=build /app/dist/storefront /usr/share/nginx/html
EXPOSE 4200
CMD ["nginx", "-g", "daemon off;"]

