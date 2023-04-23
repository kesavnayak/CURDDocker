FROM node:latest as node
WORKDIR /app
COPY . .
RUN npm install
EXPOSE 4200
CMD npm start


# FROM nginx:alpine
# COPY --from=node /app/dist/frontend /usr/share/nginx/html