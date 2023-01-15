import { TestBed } from '@angular/core/testing';

import { FurnitureApiService } from './furniture-api.service';

describe('FurnitureApiService', () => {
  let service: FurnitureApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FurnitureApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
