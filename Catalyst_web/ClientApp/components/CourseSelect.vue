// CourseSelect.vue
<template>
  <vue-select v-if="courses.length > 0"
              v-model="selectedCourseId"
              :options="formattedCourses"
              placeholder="Choose a course...">
    <template #option="{ option }">
      {{ option && option.title }}
    </template>
  </vue-select>
</template>

<script>
  import VueSelect from 'vue-select';

  export default {
    components: {
      VueSelect,
    },
    props: {
      value: {
        type: Number,
        default: null,
      },
      courses: {
        type: Array,
        required: true,
      },
    },
    data() {
      return {
        selectedCourseId: null,
      };
    },
    computed: {
      formattedCourses() {
        // Convert courses array to the format expected by vue-select
        return this.courses.map(course => ({ title: course.title, value: course.id }));
      },
    },
    watch: {
      formattedCourses: {
        handler(newValue) {
          console.log('Formatted Courses:', newValue);
        },
        immediate: true, // Log on component creation
      },
    },
    methods: {
      handleInput(value) {
        this.$emit('input', value);
      },
    },
  };
</script>
