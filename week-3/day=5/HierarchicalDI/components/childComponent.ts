import { inject, injectable } from 'inversify';
import { TYPES } from '../types';
import { DataService } from '../services/dataService';
import { LoggerService } from '../services/loggerService';

@injectable()
class ChildComponent {
  constructor(
    @inject(TYPES.LoggerService) private loggerService: LoggerService,
    @inject(TYPES.DataService) private dataService: DataService
  ) {}

  processData(): void {
    this.loggerService.log('ChildComponent processing data');
    const data = this.dataService.getData();
    console.log(`[ChildComponent] Data: ${data}`);
  }
}

export { ChildComponent };
