import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Voter } from '../models/voter';


@Component({
  selector: 'app-voters',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './voters.component.html',
  styleUrl: './voters.component.css'
})
export class VotersComponent {
  http = inject(HttpClient);
  voters: Voter[] = [];

  ngOnInit(): void {
    this.getVoters();
  }

  getVoters() {
    return this.http.get<Voter[]>('https://localhost:7062/api/voter').subscribe({
      next: response => this.voters = response,
      error: error => console.log(error),
      complete: () => { console.log(this.voters) }
    });
  }
}
