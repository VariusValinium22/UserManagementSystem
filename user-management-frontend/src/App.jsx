import './App.css'
import { useUsers } from './hooks/useUsers'
import UserList from './components/UserList'

function App() {
  const { users, loading, error } = useUsers()

  return (
    <>
      <h1>User Management</h1>
      <UserList users={users} loading={loading} error={error} />
    </>
  )
}

export default App;
