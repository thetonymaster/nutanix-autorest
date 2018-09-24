#!/bin/sh

clone_repo() {
  git clone ${GH_REPO}
}

move_files() {
  mv generated ${REPO}/generated
}

setup_git() {
  cd ${REPO}
  git config --global user.email "antonio.cabreraglz@gmail.com"
  git config --global user.name "Antonio Cabrera"
}

commit_website_files() {
  pwd
  git checkout ${BRANCH}
  git add .
  git commit -m "Travis build: $TRAVIS_BUILD_NUMBER"
}

upload_files() {
  git remote add origin-generated https://${GH_TOKEN}@github.com/Nutanix/${REPO}.git > /dev/null 2>&1
  git push --set-upstream origin-generated ${BRANCH}
}

clone_repo
move_files
setup_git
commit_website_files
upload_files
