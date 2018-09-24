#!/bin/sh

setup_git() {
  git config --global user.email "antonio.cabreraglz@gmail.com"
  git config --global user.name "Antonio Cabrera"
}

commit_website_files() {
  git checkout master
  git add .
  git commit -m "Travis build: $TRAVIS_BUILD_NUMBER"
}

upload_files() {
  git remote add origin-generated https://${GH_TOKEN}@github.com/thetonymaster/nutanix-autorest.git > /dev/null 2>&1
  git push --set-upstream origin-generated master
}

setup_git
commit_website_files
upload_files
