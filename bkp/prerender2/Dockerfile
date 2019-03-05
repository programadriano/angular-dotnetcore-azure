FROM nginx:alpine

COPY ./nginx.conf /etc/nginx/nginx.conf

WORKDIR /usr/share/nginx/website/dist

COPY ./dist/ .

COPY ./package.json .

COPY ./index.js .

RUN apk add nodejs

RUN apk add npm
# install npm packages
RUN npm install --no-package-lock

CMD ["node", "index.js"]