import { injectable } from 'inversify';

@injectable()
class DataService {
  getData(): string {
    return 'Data from DataService';
  }
}

export { DataService };
