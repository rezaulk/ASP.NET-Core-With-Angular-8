import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Angular-Client';

  latestPosts: Book[] = [];  
  constructor(private http: HttpClient) { }  


  ngOnInit() {  
    this.http.get<Book[]>('https://localhost:44362/api/Books').subscribe(result => {  
      this.latestPosts = result;  
      debugger;
    }, error => console.error(error));  
  }  

}

interface Book {  
  Genre: string;  
  Author: string;  
  Title: string;  
  Price: string;  
  Publisher: string;  
  
} 

