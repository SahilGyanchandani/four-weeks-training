import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostService {
  private baseUrl = 'https://jsonplaceholder.typicode.com/posts';

  constructor(private http: HttpClient) { }

  getPosts(): Observable<any> {
    const url = `${this.baseUrl}/posts`;
    return this.http.get(url);
  }

  getPostById(id: number): Observable<any> {
    const url = `${this.baseUrl}/posts/${id}`;
    return this.http.get(url);
  }

  createPost(postData: any): Observable<any> {
    const url = `${this.baseUrl}/posts`;
    return this.http.post(url, postData);
  }

  updatePost(id: number, postData: any): Observable<any> {
    const url = `${this.baseUrl}/posts/${id}`;
    return this.http.put(url, postData);
  }

  deletePost(id: number): Observable<any> {
    const url = `${this.baseUrl}/posts/${id}`;
    return this.http.delete(url);
  }
}
