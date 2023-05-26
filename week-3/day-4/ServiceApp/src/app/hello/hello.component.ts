import { Component, OnInit } from '@angular/core';
// import { JsonPlaceholderService } from './json-placeholder.service';
import { PostService } from '../post.service';

@Component({
  selector: 'app-my-component',
  template: `
    <div *ngFor="let post of posts">
      <h2>{{ post.title }}</h2>
      <p>{{ post.body }}</p>
    </div>
  `
})
export class HelloComponent implements OnInit {
  posts: any[] = [];

  constructor(private postService: PostService) { }

  ngOnInit() {
    this.fetchPosts();
  }

  fetchPosts() {
    this.postService.getPosts().subscribe(
      (response: any[]) => {
        this.posts = response;
      },
      (error) => {
        console.error('Error fetching posts:', error);
      }
    );
  }
}
