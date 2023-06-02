import { injectable } from 'inversify';

@injectable()
class LoggerService {
  log(message: string): void {
    console.log(`[LoggerService] ${message}`);
  }
}

export { LoggerService };
