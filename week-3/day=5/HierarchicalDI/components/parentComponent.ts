import { inject, injectable } from 'inversify';
import { TYPES } from '../types';
import { DataService } from '../services/dataService';
import { LoggerService } from '../services/loggerService';

@injectable()
class ParentComponent {
  constructor(
    @inject(TYPES.LoggerService) private loggerService: LoggerService,
    @inject(TYPES.DataService) private dataService: DataService
  ) {}

  processData(): void {
    this.loggerService.log('ParentComponent processing data');
    const data = this.dataService.getData();
    console.log(`[ParentComponent] Data: ${data}`);
  }
}

export { ParentComponent };
