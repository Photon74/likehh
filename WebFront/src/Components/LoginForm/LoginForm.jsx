import './loginForm.css'
import React, { useEffect, useState } from 'react'
// import { Button, TextField } from '@mui/material'

const INIT_FORM = {
  email: '',
  password: '',
}

function LoginForm({ onLogin }) {
  const [form, setForm] = useState(INIT_FORM)

  useEffect(() => {
    setForm(INIT_FORM)
  }, [])


  function changeForm(e) {
    e.persist()
    setForm(prev => {
      return {
        ...prev,
        [e.target.type]: e.target.value,
      }
    })
  }

  function onSubmit(e) {
    e.preventDefault()
    console.log(form)
    // onLogin(form)
    setForm(INIT_FORM)
  }

  useEffect(() => setForm(INIT_FORM), [])

  return (
    <form onSubmit={onSubmit}>
      <h2>Вход / Регистрация</h2>
      <label>
        Почта
        <input
          className='input'
          type="email"
          value={form.email}
          onChange={changeForm}
          autoComplete='off'
        /></label>
      <label>
        Пароль
        <input
          className='input'
          type="password"
          value={form.password}
          onChange={changeForm}
          autoComplete='off'
        /></label>
      <button type="submit">
        Войти
      </button>
    </form>
  )
}

export default LoginForm