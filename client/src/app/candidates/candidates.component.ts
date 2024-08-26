import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { Candidate } from '../models/candidate';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-candidates',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './candidates.component.html',
  styleUrl: './candidates.component.css'
})
export class CandidatesComponent {
  http = inject(HttpClient);
  candidates: Candidate[] = [];

  ngOnInit(): void {
    this.getVoters();
  }

  getVoters() {
    return this.http.get<Candidate[]>('https://localhost:7062/api/candidate').subscribe({
      next: response => this.candidates = response,
      error: error => console.log(error),
      complete: () => { console.log(this.candidates) }
    });
  }
}
